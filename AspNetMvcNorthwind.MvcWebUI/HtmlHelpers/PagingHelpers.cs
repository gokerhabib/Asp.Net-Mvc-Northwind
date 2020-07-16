using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AspNetMvcNorthwind.MvcWebUI.Models;

namespace AspNetMvcNorthwind.MvcWebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString Pager(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder PagingStr = new StringBuilder();
            PagingStr.Append("<ul class='pagination d-flex flex-wrap justify-content-center'>");
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                var tagBuilder2 = new TagBuilder("li");
                var tagBuilder = new TagBuilder("a");
                tagBuilder2.AddCssClass("page-item ");
                tagBuilder.MergeAttribute("href", pageUrl(i));
                tagBuilder.AddCssClass("page-link");
                tagBuilder.InnerHtml = i.ToString();
                if (pagingInfo.CurrentPage == i)
                {
                    tagBuilder2.AddCssClass("active");
                }
                tagBuilder2.InnerHtml = tagBuilder.ToString();
                PagingStr.Append(tagBuilder2);
            }
            PagingStr.Append("</ul>");
            return MvcHtmlString.Create(PagingStr.ToString());
        }
    }
}