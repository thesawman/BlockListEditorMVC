using Marathon.Core.BlockList.BlogFeed.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Marathon.Core.BlockList.BlogFeed.ViewComponents
{
    // Copy / paste block editor alias like {alias}ViewComponent
    public class blogFeedBLEViewComponent : ViewComponent
    {
        private readonly IUmbracoHelperAccessor _umbracoHelperAccessor;
        public blogFeedBLEViewComponent(IUmbracoHelperAccessor umbracoHelperAccessor)
        {
            _umbracoHelperAccessor = umbracoHelperAccessor;
        }
        public async Task<IViewComponentResult> InvokeAsync(BlockListItem model)
        {
            var content = (BlogFeedBle)model.Content; // Replace with generated model of block
            var Posts = new List<BlogTeaserModel>();
            //do stuff here, access umbraco, whatever
            if (_umbracoHelperAccessor.TryGetUmbracoHelper(out var umbracoHelper))
            {
                //UMBRACO FETCHING LOGIC HERE - fetch nodes from umbraco, or anywhere
                Posts.Add(new BlogTeaserModel()
                {
                    Headline = "Sample Post 1", Description = "lirem ipsum dolor lum set val", Url = "/sample-post-1/"
                });
                Posts.Add(new BlogTeaserModel()
                {
                    Headline = "Sample Post 2", Description = "lirem ipsum dolor lum set val", Url = "/sample-post-2/"
                });
                Posts.Add(new BlogTeaserModel()
                {
                    Headline = "Sample Post 3", Description = "lirem ipsum dolor lum set val", Url = "/sample-post-3/"
                });
            }
            //build model from the result
            var myModel = new BlogFeedModel() {
                Headline = content.Headline,
                Button = content.Button,
                Teasers = Posts
            };
            return View($"/Views/Partials/blocklist/Components/BlogFeed.cshtml", myModel);
        }
    }
}
