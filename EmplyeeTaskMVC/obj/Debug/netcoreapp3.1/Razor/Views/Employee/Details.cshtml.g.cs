#pragma checksum "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3106330ccc10881129b3f64c1e267461c58160d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "E:\ASP.NET\EmplyeeTaskMVC\Views\_ViewImports.cshtml"
using EmplyeeTaskMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP.NET\EmplyeeTaskMVC\Views\_ViewImports.cshtml"
using EmplyeeTaskMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3106330ccc10881129b3f64c1e267461c58160d0", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7133e3150f93a90a71aaaa5a76411e9db751f9eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 6 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 7 "E:\ASP.NET\EmplyeeTaskMVC\Views\Employee\Details.cshtml"
Write(Html.ActionLink("Logout", "Login","Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
