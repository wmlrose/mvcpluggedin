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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/ChangePassword.cshtml")]
    public partial class ChangePassword : System.Web.Mvc.WebViewPage<Geocrest.Web.Mvc.Models.ChangePassword>
    {
        public ChangePassword()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Account\ChangePassword.cshtml"
  
    ViewBag.Title = "Change Password";

            
            #line default
            #line hidden
WriteLiteral("\r\n<section");

WriteLiteral(" class=\"page\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row text-center changepassword\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3 title\"");

WriteLiteral(">\r\n                <h2>Use this form to change your password.</h2>\r\n\r\n           " +
"     <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(">\r\n                    Passwords must be at least ");

            
            #line 13 "..\..\Views\Account\ChangePassword.cshtml"
                                          Write(Membership.MinRequiredPasswordLength);

            
            #line default
            #line hidden
WriteLiteral(" characters long.\r\n                </div>\r\n            </div>\r\n\r\n            <div" +
"");

WriteLiteral(" class=\"col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3\"");

WriteLiteral(">\r\n");

            
            #line 18 "..\..\Views\Account\ChangePassword.cshtml"
                
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Account\ChangePassword.cshtml"
                 using (Html.BeginForm("changepassword", "account",
                    new { area = "" }, FormMethod.Post, new { @class = "form-horizontal well" }))
                {
                    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Account\ChangePassword.cshtml"
               Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Account\ChangePassword.cshtml"
                                            
                    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Account\ChangePassword.cshtml"
               Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Account\ChangePassword.cshtml"
                                             

                    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Account\ChangePassword.cshtml"
               Write(Forms.TextBox(Html, m => m.OldPassword, new { @class = "form-control"}));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Account\ChangePassword.cshtml"
                                                                                            
                    
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Account\ChangePassword.cshtml"
               Write(Forms.TextBox(Html, m => m.NewPassword, new { @class = "form-control"}));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Account\ChangePassword.cshtml"
                                                                                            
                    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Account\ChangePassword.cshtml"
               Write(Forms.TextBox(Html, m => m.ConfirmPassword, new { @class = "form-control"}));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Account\ChangePassword.cshtml"
                                                                                                

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-8 col-sm-offset-4\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary btn-block\"");

WriteLiteral(">Change password</button>\r\n                        </div>\r\n                    </" +
"div>\r\n");

            
            #line 32 "..\..\Views\Account\ChangePassword.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");

        }
    }
}
#pragma warning restore 1591
