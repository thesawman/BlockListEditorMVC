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
                var myBlogIndex = umbracoHelper.ContentAtXPath("//home/blogIndex")?.FirstOrDefault();
                var blogPostNodes = myBlogIndex?.ChildrenOfType("blogPost")?.OrderByDescending(x => x.CreateDate).Take(content.NumberToPull);
                if (blogPostNodes?.Count() > 0)
                {
                    foreach (var blogNode in blogPostNodes)
                    {
                        var myBlogNode = (BlogPost)blogNode;
                        Posts.Add(new BlogTeaserModel()
                        {
                            Headline = myBlogNode.Headline,
                            ImageUrl = myBlogNode?.FeaturedImage?.Url(),
                            ImageAlt = myBlogNode.FeaturedImage?.Name,
                            Description = myBlogNode.Teaser,
                            Url = myBlogNode.Url()
                        });
                    }
                }
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
