#pragma checksum "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DevelopersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75a1049bc51ae2687639f51b27249407dd1e4e16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_DevelopersList), @"mvc.1.0.view", @"/Views/Tasks/DevelopersList.cshtml")]
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
#line 1 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\_ViewImports.cshtml"
using Laboratorio4_ED1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\_ViewImports.cshtml"
using Laboratorio4_ED1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a1049bc51ae2687639f51b27249407dd1e4e16", @"/Views/Tasks/DevelopersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5fa8eeaf1d19abb1b8d33e0c46dcd6de13642f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_DevelopersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Laboratorio4_ED1.Models.Developer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DevelopersList.cshtml"
  
    ViewBag.Title = "DevelopersList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DevelopersList.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>DevelopersList</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DevelopersList.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DevelopersList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DevelopersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DevelopersList.cshtml"
           Write(Html.ActionLink("Review Tasks", "DeveloperReview", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DevelopersList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Laboratorio4_ED1.Models.Developer>> Html { get; private set; }
    }
}
#pragma warning restore 1591