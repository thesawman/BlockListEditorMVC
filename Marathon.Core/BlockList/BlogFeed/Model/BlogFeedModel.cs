using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Web.Common.PublishedModels;
namespace Marathon.Core.BlockList.BlogFeed.Models
{
	//Goes to the view
	public class BlogFeedModel
	{
		//Goes to the view
		public string? Headline { get; set; } //for example
		public List<BlogTeaserModel>? Teasers { get; set; } //for example
		public Link? Button { get; set; } //for example
	}
}
