#pragma checksum "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4b917d6f47f2f4c4f7f1a2deaee3ec9cfcd6d4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_DeveloperProfile), @"mvc.1.0.view", @"/Views/Tasks/DeveloperProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b917d6f47f2f4c4f7f1a2deaee3ec9cfcd6d4b", @"/Views/Tasks/DeveloperProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5fa8eeaf1d19abb1b8d33e0c46dcd6de13642f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_DeveloperProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Laboratorio4_ED1.Models.Developer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
  
    ViewBag.Title = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>DeveloperProfile</h2>\r\n\r\n<h3><strong>");
#nullable restore
#line 13 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
       Write(Html.DisplayFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n\r\n<h4>You have <strong>");
#nullable restore
#line 15 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
                Write(Html.DisplayFor(model => model.Tasks.TasksQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> pending tasks</h4>\r\n\r\n<h4><strong>Your current task information is shown below</strong></h4>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
Write(Html.ActionLink("Add Task", "CreateTask"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>Tasks</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentTask.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 30 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
       Write(Html.DisplayFor(model => model.CurrentTask.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 34 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentTask.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 38 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
       Write(Html.DisplayFor(model => model.CurrentTask.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 42 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentTask.Proyect));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 46 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
       Write(Html.DisplayFor(model => model.CurrentTask.Proyect));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 49 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentTask.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 53 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
       Write(Html.DisplayFor(model => model.CurrentTask.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
#nullable restore
#line 58 "C:\Users\ZeroJChang\Desktop\Laboratorio 4\Laboratorio4_ED1\Laboratorio4_ED1\Views\Tasks\DeveloperProfile.cshtml"
Write(Html.ActionLink("Mark as done and get the next task", "DeveloperProfile", new { change = 1 }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Laboratorio4_ED1.Models.Developer> Html { get; private set; }
    }
}
#pragma warning restore 1591