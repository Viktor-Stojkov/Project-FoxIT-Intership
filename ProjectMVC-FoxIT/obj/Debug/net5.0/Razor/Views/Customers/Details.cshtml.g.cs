#pragma checksum "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a76b046f37f4c066ea7edf7ee18b6489dbdd76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a76b046f37f4c066ea7edf7ee18b6489dbdd76", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff6e1123ffe42d85faf1b8ee8c7158f682a68b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectMVC_FoxIT.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-md btn-danger my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary float-left shadow-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary float-right shadow-lg mr-n4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Details</h1>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row shadow-lg border border-info ml-1\">\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 16 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 19 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 22 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 25 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 28 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 31 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 34 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 37 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 40 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 43 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 46 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Web));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 49 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Web));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 52 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Edb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 55 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Edb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 58 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 61 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 64 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 67 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 70 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 73 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 76 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 79 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 82 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 85 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 87 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
         if (Model.IsActive.HasValue && !Model.IsActive.Value)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br/>\r\n            <dd class=\"col-sm-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a76b046f37f4c066ea7edf7ee18b6489dbdd7616408", async() => {
                WriteLiteral("<i class=\"fas fa-trash\"></i> Delete");
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
#line 91 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
                                         WriteLiteral(Model.CustomerId);

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
#line 93 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n    <div class=\"form-group mt-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a76b046f37f4c066ea7edf7ee18b6489dbdd7619198", async() => {
                WriteLiteral("<i class=\"fas fa-arrow-circle-left\"></i> Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a76b046f37f4c066ea7edf7ee18b6489dbdd7620496", async() => {
                WriteLiteral("Edit  <i class=\"fas fa-user-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\vices\Desktop\Viktor Folder\03. FoxIT - Intership Full Stack .NET Developer\Classes\FoxIT - GitHub Project\WorkOrders-V.S\ProjectMVC-FoxIT\Views\Customers\Details.cshtml"
                               WriteLiteral(Model.CustomerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectMVC_FoxIT.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
