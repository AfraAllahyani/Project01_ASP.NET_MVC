#pragma checksum "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Men.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd9ac5286ad7dd3f22d82b3c7523ade380e1405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Men), @"mvc.1.0.view", @"/Views/Categories/Men.cshtml")]
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
#line 1 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/_ViewImports.cshtml"
using Nike_Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/_ViewImports.cshtml"
using Nike_Store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd9ac5286ad7dd3f22d82b3c7523ade380e1405", @"/Views/Categories/Men.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"511e02ec4a519f470d8b988d39397bc7ef9e1001", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Men : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Men.cshtml"
  
    var items = (List<MenProudctsModel>)ViewData["MenProducts"];
    Layout = "WebLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\n        <div class=\"row\">\n");
#nullable restore
#line 7 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Men.cshtml"
             foreach (var item in items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-4\">\n                    <div class=\"card\" style=\"width: 18rem;\">\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 354, "\"", 369, 1);
#nullable restore
#line 11 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Men.cshtml"
WriteAttributeValue("", 360, item.Img, 360, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"card-body\">\n                            <p class=\"card-text\">Type: ");
#nullable restore
#line 13 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Men.cshtml"
                                                  Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"card-text\">Size: ");
#nullable restore
#line 14 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Men.cshtml"
                                                  Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"card-text\">Price: ");
#nullable restore
#line 15 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Men.cshtml"
                                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" SAR</p>\n                            <button type=\"button\" class=\"btn btn-outline-success\">Add to cart</button>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 20 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Men.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n");
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
