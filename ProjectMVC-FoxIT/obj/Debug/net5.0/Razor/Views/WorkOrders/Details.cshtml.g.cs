#pragma checksum "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73b9e9c973c2b221adf8858550247ccca54cf5ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOrders_Details), @"mvc.1.0.view", @"/Views/WorkOrders/Details.cshtml")]
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
#line 1 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\_ViewImports.cshtml"
using ProjectMVC_FoxIT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\_ViewImports.cshtml"
using ProjectMVC_FoxIT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73b9e9c973c2b221adf8858550247ccca54cf5ed", @"/Views/WorkOrders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff6e1123ffe42d85faf1b8ee8c7158f682a68b7", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOrders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectMVC_FoxIT.Models.WorkOrder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-md btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-md btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-md btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>WorkOrder</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerNote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PerformedWorks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.PerformedWorks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Minutes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Minutes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 91 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
         if (Model.IsActive.HasValue && !Model.IsActive.Value)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73b9e9c973c2b221adf8858550247ccca54cf5ed17199", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
                                         WriteLiteral(Model.WorkOrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  ");
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 96 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73b9e9c973c2b221adf8858550247ccca54cf5ed19937", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\WorkOrders\Details.cshtml"
                           WriteLiteral(Model.WorkOrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73b9e9c973c2b221adf8858550247ccca54cf5ed22273", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectMVC_FoxIT.Models.WorkOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
