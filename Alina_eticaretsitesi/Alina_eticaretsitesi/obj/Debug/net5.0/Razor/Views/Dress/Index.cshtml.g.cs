#pragma checksum "C:\Users\helin\source\repos\Alina_eticaretsitesi\Alina_eticaretsitesi\Views\Dress\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23c6bc51ed00e6c920d2f69c7f4369db9c529776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dress_Index), @"mvc.1.0.view", @"/Views/Dress/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c6bc51ed00e6c920d2f69c7f4369db9c529776", @"/Views/Dress/Index.cshtml")]
    public class Views_Dress_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alina_eticaretsitesi.Data.Models.Dress>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\helin\source\repos\Alina_eticaretsitesi\Alina_eticaretsitesi\Views\Dress\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Dress List</h3>\r\n<br />\r\n<table class=\" table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Dress Name</th>\r\n        <th>Category Name</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n        <th>Details</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\helin\source\repos\Alina_eticaretsitesi\Alina_eticaretsitesi\Views\Dress\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n\r\n    <td>");
#nullable restore
#line 21 "C:\Users\helin\source\repos\Alina_eticaretsitesi\Alina_eticaretsitesi\Views\Dress\Index.cshtml"
   Write(x.DressID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\helin\source\repos\Alina_eticaretsitesi\Alina_eticaretsitesi\Views\Dress\Index.cshtml"
   Write(x.DressName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n    <td></td>\r\n    <td><a href=\"#\" class=\" btn btn-danger\">Delete</a></td>\r\n    <td><a href=\"#\" class=\" btn btn-success\">Update</a></td>\r\n    <td><a href=\"#\" class=\" btn btn-info\">Details</a></td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 29 "C:\Users\helin\source\repos\Alina_eticaretsitesi\Alina_eticaretsitesi\Views\Dress\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"#\" class=\" btn btn-primary\">New Dress</a>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alina_eticaretsitesi.Data.Models.Dress>> Html { get; private set; }
    }
}
#pragma warning restore 1591
