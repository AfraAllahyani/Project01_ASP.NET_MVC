#pragma checksum "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa961ebf21e4935ee589fa173e5264d91efb3d73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa961ebf21e4935ee589fa173e5264d91efb3d73", @"/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"511e02ec4a519f470d8b988d39397bc7ef9e1001", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Index.cshtml"
  
    var items = (List<CategorieModel>)ViewData["Categories"];
    Layout = "WebLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <h2 class=""center"">Trending Now</h2>
        <div class=""content section"" style=""max-width:500px"">
            <img class=""mySlides"" src=""https://images.unsplash.com/photo-1580894529573-fc5e3f78ba06?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjN8fG5pa2V8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60"" style=""width:100%"">
            <img class=""mySlides"" src=""https://images.unsplash.com/photo-1524532787116-e70228437bbe?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTV8fG5pa2V8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60"" style=""width:100%"">
            <img class=""mySlides"" src=""https://images.unsplash.com/photo-1597464993881-035964af094d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80"" style=""width:100%"">
        </div>
    </div>
    <hr>
    <div class=""row"">
");
#nullable restore
#line 16 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Index.cshtml"
         foreach (var item in items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-4\">\n                <h4>");
#nullable restore
#line 19 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Index.cshtml"
               Write(item.Categorie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                <img style=\"width:400px;height:300px\"");
            BeginWriteAttribute("src", " src=\"", 1142, "\"", 1157, 1);
#nullable restore
#line 20 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Index.cshtml"
WriteAttributeValue("", 1148, item.Img, 1148, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n");
#nullable restore
#line 22 "/Users/afra/Desktop/dotNetProjects/Project01_ASP.NET_MVC/Nike_Store/Nike_Store/Views/Categories/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<script>var myIndex = 0;
    carousel();

    function carousel() {
        var i;
        var x = document.getElementsByClassName(""mySlides"");
        for (i = 0; i < x.length; i++) {
            x[i].style.display = ""none"";
        }
        myIndex++;
        if (myIndex > x.length) { myIndex = 1 }
        x[myIndex - 1].style.display = ""block"";
        setTimeout(carousel, 3000);
    }</script>




");
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
