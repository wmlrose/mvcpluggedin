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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Help/DisplayTemplates/ImageSample.cshtml")]
    public partial class ImageSample_ : System.Web.Mvc.WebViewPage<Geocrest.Web.Mvc.Documentation.ImageSample>
    {
        public ImageSample_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<img");

WriteAttribute("src", Tuple.Create(" src=\"", 57), Tuple.Create("\"", 73)
            
            #line 3 "..\..\Views\Help\DisplayTemplates\ImageSample.cshtml"
, Tuple.Create(Tuple.Create("", 63), Tuple.Create<System.Object, System.Int32>(Model.Src
            
            #line default
            #line hidden
, 63), false)
);

WriteLiteral(" />");

        }
    }
}
#pragma warning restore 1591
