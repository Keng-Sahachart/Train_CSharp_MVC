#pragma checksum "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "163e51c6cb5c89faeeb020edbeab534c8e066f63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
#line 1 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\_ViewImports.cshtml"
using Ex_9_0_CrudCore;

#line default
#line hidden
#line 2 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\_ViewImports.cshtml"
using Ex_9_0_CrudCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163e51c6cb5c89faeeb020edbeab534c8e066f63", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ade01671db6497a4074830ed5be83dc24b61c8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ex_9_0_CrudCore.Models.db.Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 24, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2702, 178, true);
            WriteLiteral("<h4>รายละเอียด Products</h4>\r\n<hr />\r\n<div class=\"card col-md-6 border-success\">\r\n\r\n    <div class=\"card-header border-success\">\r\n        <h2 class=\"alert-success\">\r\n            ");
            EndContext();
            BeginContext(2881, 41, false);
#line 83 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(2922, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(2938, 43, false);
#line 84 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(2981, 58, true);
            WriteLiteral("\r\n        </h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
            EndContext();
            BeginContext(3241, 49, true);
            WriteLiteral("\r\n        <div class=\"card-text\">\r\n\r\n            ");
            EndContext();
            BeginContext(3291, 47, false);
#line 96 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(3338, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(3354, 43, false);
#line 97 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(3397, 65, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(3463, 51, false);
#line 101 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(3514, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(3530, 47, false);
#line 102 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(3577, 65, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(3643, 45, false);
#line 106 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3688, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(3704, 41, false);
#line 107 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3745, 65, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(3811, 48, false);
#line 111 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(3859, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(3875, 44, false);
#line 112 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(3919, 65, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(3985, 48, false);
#line 116 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(4033, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(4049, 44, false);
#line 117 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(4093, 65, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(4159, 48, false);
#line 121 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(4207, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(4223, 44, false);
#line 122 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(4267, 65, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(4333, 48, false);
#line 126 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(4381, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(4397, 44, false);
#line 127 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(4441, 65, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(4507, 43, false);
#line 131 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NewData));

#line default
#line hidden
            EndContext();
            BeginContext(4550, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(4566, 39, false);
#line 132 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.NewData));

#line default
#line hidden
            EndContext();
            BeginContext(4605, 65, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(4671, 44, false);
#line 136 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(4715, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(4731, 53, false);
#line 137 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(4784, 65, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(4850, 44, false);
#line 141 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(4894, 15, true);
            WriteLiteral(":\r\n            ");
            EndContext();
            BeginContext(4910, 52, false);
#line 142 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Supplier.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(4962, 20, true);
            WriteLiteral("\r\n        </div>\r\n\r\n");
            EndContext();
            BeginContext(5002, 55, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"card-footer\">\r\n        ");
            EndContext();
            BeginContext(5057, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "163e51c6cb5c89faeeb020edbeab534c8e066f6314246", async() => {
                BeginContext(5134, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 150 "E:\#DEV_Mvc\ExPj_MVC\Ex_10_1_CrudCore-Bootstrap\Views\Products\Details.cshtml"
                               WriteLiteral(Model.ProductId);

#line default
#line hidden
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
            EndContext();
            BeginContext(5142, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(5154, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "163e51c6cb5c89faeeb020edbeab534c8e066f6316666", async() => {
                BeginContext(5200, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(5216, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ex_9_0_CrudCore.Models.db.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
