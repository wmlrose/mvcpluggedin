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

namespace Geocrest.Web.Mvc.EmbeddedViews
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Help/DisplayTemplates/TextSample.cshtml")]
    public partial class TextSample_ : System.Web.Mvc.WebViewPage<Geocrest.Web.Mvc.Documentation.TextSample>
    {
        public TextSample_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<pre");

WriteLiteral(" class=\"wrapped\"");

WriteLiteral(">\r\n");

            
            #line 3 "..\..\Views\Help\DisplayTemplates\TextSample.cshtml"
 if (Model.MediaTypes != null && Model.MediaTypes.Any<System.Net.Http.Headers.MediaTypeHeaderValue>(x =>
    x.MediaType.ToLower().Contains("json")))
{
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Help\DisplayTemplates\TextSample.cshtml"
Write(Html.Raw(Model.Text));

            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Help\DisplayTemplates\TextSample.cshtml"
                         ;
}
else
{
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Help\DisplayTemplates\TextSample.cshtml"
Write(Html.Raw(HttpUtility.HtmlEncode(@Model.Text).Replace("\\r\\n", "</br>")));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Help\DisplayTemplates\TextSample.cshtml"
                                                                                
}

            
            #line default
            #line hidden
WriteLiteral("</pre>");

        }
    }
}
#pragma warning restore 1591
