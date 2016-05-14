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

namespace Geocrest.Web.Mvc.Views.Account
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Login.cshtml")]
    public partial class Login : System.Web.Mvc.WebViewPage<Geocrest.Web.Mvc.Models.Login>
    {
        public Login()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Account\Login.cshtml"
  
    ViewBag.Title = "Log in";

            
            #line default
            #line hidden
WriteLiteral("\r\n<section");

WriteLiteral(" class=\"page\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row text-center login\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4 title\"");

WriteLiteral(">\r\n                <h2>Login to your account</h2>\r\n            </div>\r\n          " +
"  <div");

WriteLiteral(" class=\"col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..\Views\Account\Login.cshtml"
                
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Account\Login.cshtml"
                 using (Html.BeginForm("login", "account", new { ReturnUrl = @Url.Action("index", "home", new { area = "" }), area = "" },
                FormMethod.Post, new { @class = "well" }))
                {
                    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Account\Login.cshtml"
               Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Account\Login.cshtml"
                                            

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group input-group\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i></span>\r\n");

WriteLiteral("                        ");

            
            #line 18 "..\..\Views\Account\Login.cshtml"
                   Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control", placeholder = "Username", id = "user" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group input-group\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-key\"");

WriteLiteral("></i></span>\r\n");

WriteLiteral("                        ");

            
            #line 22 "..\..\Views\Account\Login.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", placeholder = "Password", id = "pw" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"remember\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" data-val=\"true\"");

WriteLiteral(" data-val-required=\"The Remember me? field is required.\"");

WriteLiteral("\r\n                                   id=\"remember\"");

WriteLiteral(" name=\"RememberMe\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" />\r\n                            Remember Me?\r\n                        </label>\r\n" +
"                    </div>\r\n");

WriteLiteral("                    <input");

WriteLiteral(" class=\"btn btn-primary btn-block\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Sign In\"");

WriteLiteral(" />\r\n");

            
            #line 32 "..\..\Views\Account\Login.cshtml"
                    
                    
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Account\Login.cshtml"
               Write(Html.ValidationSummary(true, "Log in was unsuccessful."));

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Account\Login.cshtml"
                                                                             
                    
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");

        }
    }
}
#pragma warning restore 1591
