using Marathon.Core.BlockList.BlogFeed.Models;
using Marathon.Core.BlockList.Models;
using Marathon.Core.BlockList.RichTextEditor.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Marathon.Core.BlockList.SampleBlockEditor.ViewComponents
{
    // Copy / paste block editor alias like {alias}ViewComponent
    public class richTextBleViewComponent : ViewComponent
    {
        
        public async Task<IViewComponentResult> InvokeAsync(BlockListItem model)
        {
            var content = (RichTextBle)model.Content; // Replace with generated model of block

            var myModel = new RTEModel() {
                CommonSettings = new CommonSettingsModel((CommonBlockListSettings)model.Settings),
                Content = content.Content?.ToString()
            };

            return View($"/Views/Partials/blocklist/Components/RichTextEditor.cshtml", myModel);
        }
    }
}
