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
    
    #line 2 "..\..\Views\Help\DisplayTemplates\LinkSample.cshtml"
    using Geocrest.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Help/DisplayTemplates/LinkSample.cshtml")]
    public partial class _LinkSample : System.Web.Mvc.WebViewPage<Geocrest.Web.Mvc.Documentation.LinkSample>
    {
        public _LinkSample()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Help\DisplayTemplates\LinkSample.cshtml"
 foreach(var kvp in Model.Urls)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("href", Tuple.Create(" href=\"", 142), Tuple.Create("\"", 157)
            
            #line 5 "..\..\Views\Help\DisplayTemplates\LinkSample.cshtml"
, Tuple.Create(Tuple.Create("", 149), Tuple.Create<System.Object, System.Int32>(kvp.Key
            
            #line default
            #line hidden
, 149), false)
);

WriteLiteral(">");

            
            #line 5 "..\..\Views\Help\DisplayTemplates\LinkSample.cshtml"
                                          Write(kvp.Value);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 6 "..\..\Views\Help\DisplayTemplates\LinkSample.cshtml"
}

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Help\DisplayTemplates\LinkSample.cshtml"
 foreach (var kvp in Model.Routes)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("href", Tuple.Create(" href=\"", 247), Tuple.Create("\"", 280)
            
            #line 9 "..\..\Views\Help\DisplayTemplates\LinkSample.cshtml"
, Tuple.Create(Tuple.Create("", 254), Tuple.Create<System.Object, System.Int32>(Url.HttpRouteUrl(kvp.Key)
            
            #line default
            #line hidden
, 254), false)
);

WriteLiteral(">");

            
            #line 9 "..\..\Views\Help\DisplayTemplates\LinkSample.cshtml"
                                                            Write(kvp.Value);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 10 "..\..\Views\Help\DisplayTemplates\LinkSample.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591