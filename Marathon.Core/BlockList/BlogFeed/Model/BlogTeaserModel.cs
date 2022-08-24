using Umbraco.Cms.Core.Models;

namespace Marathon.Core.BlockList.BlogFeed.Models
{
	//Goes to the view
	public class BlogTeaserModel
	{
		public string Headline { get; set; } 
		public string Description { get; set; } 
		public string ImageUrl { get; set; }
		public string ImageAlt { get; set; }

		public string Url { get; set; } 
	}

}
