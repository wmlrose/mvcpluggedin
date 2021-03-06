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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Register.cshtml")]
    public partial class Register : System.Web.Mvc.WebViewPage<Geocrest.Web.Mvc.Models.Register>
    {
        public Register()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Account\Register.cshtml"
  
    ViewBag.Title = "Register";

            
            #line default
            #line hidden
WriteLiteral("\r\n<section");

WriteLiteral(" class=\"page\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row text-center register\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3 title\"");

WriteLiteral(">\r\n                <h2>Create a new account</h2>\r\n                <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(">\r\n                    Passwords must be at least 8 characters long.\r\n           " +
"     </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3\"");

WriteLiteral(">\r\n");

            
            #line 15 "..\..\Views\Account\Register.cshtml"
                
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Account\Register.cshtml"
                 using (Html.BeginForm("register", "account", new { area = "" }, FormMethod.Post, new { @class = "form-horizontal text-left well" }))
                {
                    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\Register.cshtml"
               Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\Register.cshtml"
                                            
                    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Account\Register.cshtml"
               Write(Forms.TextBox(Html, x => x.UserName, new { @class = "form-control" }));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Account\Register.cshtml"
                                                                                          
                    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Account\Register.cshtml"
               Write(Forms.TextBox(Html, x => x.FirstName, new { @class = "form-control" }));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Account\Register.cshtml"
                                                                                           
                    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Account\Register.cshtml"
               Write(Forms.TextBox(Html, x => x.LastName, new { @class = "form-control" }));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Account\Register.cshtml"
                                                                                          
                    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Account\Register.cshtml"
               Write(Forms.TextBox(Html, x => x.Email, new { @class = "form-control" }));

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Account\Register.cshtml"
                                                                                       
                    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Account\Register.cshtml"
               Write(Forms.TextBox(Html, x => x.Password, new { @class = "form-control", type = "password" }));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Account\Register.cshtml"
                                                                                                             
                    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Account\Register.cshtml"
               Write(Forms.TextBox(Html, x => x.ConfirmPassword, new { @class = "form-control", type = "password" }));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Account\Register.cshtml"
                                                                                                                    

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-8 col-sm-offset-4\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary btn-block\"");

WriteLiteral(">Register</button>\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 29 "..\..\Views\Account\Register.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");

        }
    }
}
#pragma warning restore 1591
