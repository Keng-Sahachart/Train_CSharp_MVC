#pragma checksum "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "522bf21d3d11261ed8e5dab919421501ee02e071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ByViewModel), @"mvc.1.0.view", @"/Views/Home/ByViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ByViewModel.cshtml", typeof(AspNetCore.Views_Home_ByViewModel))]
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
#line 1 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\_ViewImports.cshtml"
using _4_4_UsingMultipleModels;

#line default
#line hidden
#line 2 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\_ViewImports.cshtml"
using _4_4_UsingMultipleModels.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522bf21d3d11261ed8e5dab919421501ee02e071", @"/Views/Home/ByViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde9a2aa22f9e20719c96d1a2d000f623e2e19ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ByViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_4_4_UsingMultipleModels.Models.ViewDataModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
  
    ViewData["Title"] = "ByViewModel";

#line default
#line hidden
            BeginContext(126, 323, true);
            WriteLiteral(@"
    <div>
        <h4>ViewModel  / ViewDataModel</h4>
        <pre>
            เหมือนสร้าง class แล้ว ประกาศตัวแปร Class ไว้เก็บค่า
            ต้องรับค่ามาแสดงผ่าน method view
            ต้องเรียกใช้งาน ด้วย model ใน foreach
        </pre>
        <hr />
        <dl class=""row"">
        </dl>
    </div>

");
            EndContext();
            BeginContext(601, 150, true);
            WriteLiteral("\r\n<h1> แบบ ==> ByViewModel</h1>\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>รหัสลูกค้า</th>\r\n        <th>ชื่อ-สกุล</th>\r\n        <th>ที่อยู่</th>\r\n\r\n");
            EndContext();
#line 33 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
         foreach (var item in Model.GetCustomers)
        {

#line default
#line hidden
            BeginContext(813, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(844, 15, false);
#line 36 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
           Write(item.CustomerID);

#line default
#line hidden
            EndContext();
            BeginContext(859, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(883, 13, false);
#line 37 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
           Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(896, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(920, 12, false);
#line 38 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
           Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(932, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
    }

#line default
#line hidden
            BeginContext(961, 191, true);
            WriteLiteral("        </tr>\r\n    </table>\r\n    <br />\r\n\r\n    <table border=\"1\">\r\n        <tr>\r\n            <th>รหัสสินค้า</th>\r\n            <th>ชื่อสินค้า</th>\r\n            <th>ราคา</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 52 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
         foreach (var item in Model.GetProducts)
        {

#line default
#line hidden
            BeginContext(1213, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1252, 14, false);
#line 55 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
               Write(item.ProductID);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1294, 16, false);
#line 56 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
               Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1310, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1338, 17, false);
#line 57 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
               Write(item.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1355, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 59 "E:\ProjectDEV\#ExPj_MVC\4-4 UsingMultipleModels\Views\Home\ByViewModel.cshtml"
        }

#line default
#line hidden
            BeginContext(1392, 18, true);
            WriteLiteral("    </table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_4_4_UsingMultipleModels.Models.ViewDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591