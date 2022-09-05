using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Marathon.Core.BlockList.Models
{
    public class CommonSettingsModel
    {
        //block editor settings available for ALL block editors, ex. margins, fullwidth, maxwidth, 
        public string BottomMargin { get; set; }
        public string TopMargin { get; set; }
        public bool FullWidth { get; set; }
        public string MaxWidth { get; set; }

        public CommonSettingsModel(CommonBlockListSettings settings)
        {
            TopMargin = settings.TopMargin != null ? settings.TopMargin : "";
            BottomMargin = settings.BottomMargin != null ? settings.BottomMargin : "";
            MaxWidth = settings.MaxWidth != null ? settings.MaxWidth : "";
        }
        public CommonSettingsModel()
        {

        }

    }
}
