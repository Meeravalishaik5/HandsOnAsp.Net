#pragma checksum "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1204dd54126eb2af48c9ec0bf33103a00331f51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1204dd54126eb2af48c9ec0bf33103a00331f51", @"/Views/User/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"704007baf1dc9824fb5c6c9d9abf46b976d6c108", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
  
    ViewData["Title"] = "Create";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
#nullable restore
#line 8 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>Name</td>\r\n        <td>");
#nullable restore
#line 13 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m=>m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Email</td>\r\n        <td>");
#nullable restore
#line 18 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>DOB</td>\r\n        <td>");
#nullable restore
#line 23 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.DOB,null,new { @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("    </tr>\r\n    <tr>\r\n        <td>Country</td>\r\n        <td>");
#nullable restore
#line 28 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.DropDownListFor(m => m.Country, ViewBag.country as SelectList,"Select Country"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>UserName</td>\r\n        <td>");
#nullable restore
#line 33 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td style=\"color:red\">");
#nullable restore
#line 34 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
                         Write(Html.ValidationMessageFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Password</td>\r\n        <td>");
#nullable restore
#line 38 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\">\r\n            <input type=\"submit\" value=\"Register\"/>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 47 "E:\ASP.NET\HandsOnMVCModelValidations\Views\User\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591