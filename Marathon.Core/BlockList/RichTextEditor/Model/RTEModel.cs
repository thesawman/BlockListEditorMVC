using Marathon.Core.BlockList.Models;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Web.Common.PublishedModels;
namespace Marathon.Core.BlockList.RichTextEditor.Models
{
	//Goes to the view
	public class RTEModel: IBlockListModel
	{
        //Goes to the view
        //global block editor settings, ex. margins
        public CommonSettingsModel? CommonSettings { get; set; }
        public string? Content { get; set; }
	}
}
