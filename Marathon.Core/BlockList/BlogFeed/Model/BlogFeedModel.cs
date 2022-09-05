﻿using Marathon.Core.BlockList.Models;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Web.Common.PublishedModels;
namespace Marathon.Core.BlockList.BlogFeed.Models
{
	//Goes to the view
	public class BlogFeedModel: IBlockListModel
	{
        //Goes to the view
        //global block editor settings, ex. margins
        public CommonSettingsModel? CommonSettings { get; set; }
        public string? Headline { get; set; } //for example
		public List<BlogTeaserModel>? Teasers { get; set; } //for example
		public Link? Button { get; set; } //for example
	}
}
