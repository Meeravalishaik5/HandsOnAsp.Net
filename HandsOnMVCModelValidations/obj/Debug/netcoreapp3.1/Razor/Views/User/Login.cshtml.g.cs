#pragma checksum "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dabf3402f7d0d48152bc9088bf8ffc389553b540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\ASP.NET\HandsOnMVCModelValidations\Views\_ViewImports.cshtml"
using HandsOnMVCModelValidations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP.NET\HandsOnMVCModelValidations\Views\_ViewImports.cshtml"
using HandsOnMVCModelValidations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dabf3402f7d0d48152bc9088bf8ffc389553b540", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"704007baf1dc9824fb5c6c9d9abf46b976d6c108", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n");
#nullable restore
#line 7 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>Username</td>\r\n        <td>");
#nullable restore
#line 12 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Login.cshtml"
       Write(Html.TextBox("name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Password</td>\r\n        <td>");
#nullable restore
#line 16 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Login.cshtml"
       Write(Html.Password("pwd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\"><input type=\"submit\" value=\"Login\" class=\"btn btn-primary\"/></td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            <span class=\"text-danger\">");
#nullable restore
#line 23 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Login.cshtml"
                                 Write(ViewData["err"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 27 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Login.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Login.cshtml"
Write(Html.ActionLink("Signup for New User","Create",User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
