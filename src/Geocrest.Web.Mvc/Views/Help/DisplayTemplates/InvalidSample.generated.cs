﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Help/DisplayTemplates/InvalidSample.cshtml")]
    public partial class _InvalidSample : System.Web.Mvc.WebViewPage<Geocrest.Web.Mvc.Documentation.InvalidSample>
    {
        public _InvalidSample()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Help\DisplayTemplates\InvalidSample.cshtml"
 if (HttpContext.Current.IsDebuggingEnabled)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"warning-message-container\"");

WriteLiteral(">\n        <p>");

            
            #line 6 "..\..\Views\Help\DisplayTemplates\InvalidSample.cshtml"
      Write(Model.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\n    </div>\n");

            
            #line 8 "..\..\Views\Help\DisplayTemplates\InvalidSample.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <p>Sample not available.</p>\n");

            
            #line 12 "..\..\Views\Help\DisplayTemplates\InvalidSample.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591