﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Geocrest.Web.Mvc.Views.Feedback
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Geocrest.Web.Mvc;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Feedback/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Feedback\Index.cshtml"
  
    ViewBag.Title = "Feedback";

            
            #line default
            #line hidden
WriteLiteral("\r\n<section");

WriteLiteral(" class=\"page\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"title-page\"");

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"title-description\"");

WriteLiteral(">Here\'s what people had to say...</h3>\r\n                </div>\r\n                <" +
"div");

WriteLiteral(" id=\"feedbacklist\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..\Views\Feedback\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Feedback\Index.cshtml"
                      Html.RenderAction("list", "feedback", new { area = "" });
            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</secti" +
"on>");

        }
    }
}
#pragma warning restore 1591
