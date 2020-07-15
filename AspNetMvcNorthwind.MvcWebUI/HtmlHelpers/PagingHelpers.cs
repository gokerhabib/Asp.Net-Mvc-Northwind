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
        public static MvcHtmlString Pager(this HtmlHelper html, PagingInfo pagingInfo)
        {
            
            StringBuilder PagingStr = new StringBuilder();
            PagingStr.Append("<ul class='pagination d-flex flex-wrap justify-content-center'>");
            var totalPage = (int)Math.Ceiling((decimal)pagingInfo.TotalItems / pagingInfo.ItemsPerPage);
            for (int i = 1; i <= totalPage; i++)
            {
                var tagBuilder2 = new TagBuilder("li");
                var tagBuilder = new TagBuilder("a");

                tagBuilder2.AddCssClass("page-item ");
                tagBuilder.MergeAttribute("href", String.Format("/Product/Index/?page={0}",i));
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