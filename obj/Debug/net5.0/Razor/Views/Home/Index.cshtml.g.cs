#pragma checksum "C:\Programacion1\Pc04\pc04\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a95d5dc2b827e31f1c4211954cd209e98de996e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Programacion1\Pc04\pc04\Views\_ViewImports.cshtml"
using pc04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programacion1\Pc04\pc04\Views\_ViewImports.cshtml"
using pc04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a95d5dc2b827e31f1c4211954cd209e98de996e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3c1f8b6e5f9f3a96590c1f06a9a58689d0384bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Programacion1\Pc04\pc04\Views\Home\Index.cshtml"
 if (Model.Count()==0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-center\"> No hay imagenes para mostrar </p>\r\n");
#nullable restore
#line 7 "C:\Programacion1\Pc04\pc04\Views\Home\Index.cshtml"
}else{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Programacion1\Pc04\pc04\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-2 text-center\">\r\n            <h2>");
#nullable restore
#line 11 "C:\Programacion1\Pc04\pc04\Views\Home\Index.cshtml"
           Write(item.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 254, "\"", 269, 1);
#nullable restore
#line 12 "C:\Programacion1\Pc04\pc04\Views\Home\Index.cshtml"
WriteAttributeValue("", 260, item.gif, 260, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Programacion1\Pc04\pc04\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Programacion1\Pc04\pc04\Views\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
