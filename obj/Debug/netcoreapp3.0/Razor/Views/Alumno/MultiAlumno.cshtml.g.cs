#pragma checksum "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cbd4449af8a81b6080233932a38885e067a8f14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumno_MultiAlumno), @"mvc.1.0.view", @"/Views/Alumno/MultiAlumno.cshtml")]
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
#line 1 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\_ViewImports.cshtml"
using Platzi_Asp_Net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\_ViewImports.cshtml"
using Platzi_Asp_Net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cbd4449af8a81b6080233932a38885e067a8f14", @"/Views/Alumno/MultiAlumno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c3a6a73966ec9128d523e46407006ddd567609", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumno_MultiAlumno : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alumno>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml"
  
    ViewData["Title"] = " Informacion Alumno ";
    Layout = "Simple";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n   <h1>");
#nullable restore
#line 9 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n  <strong>Desde la vista normal</strong>    \r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n  \r\n\r\n");
            WriteLiteral("     \r\n\r\n");
            WriteLiteral("\r\n<table class=\"table table-dark table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Nombre</th>\r\n            <th scope=\"col\">Id</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml"
     foreach(var alumno in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 33 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml"
           Write(alumno.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml"
           Write(alumno.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml"
                                                                      
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n    <p><i>");
#nullable restore
#line 42 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml"
     Write(ViewBag.cosadinamica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n    <p><i>");
#nullable restore
#line 43 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml"
     Write(ViewData["cosadinamica"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n    <p><i>");
#nullable restore
#line 44 "c:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Alumno\MultiAlumno.cshtml"
     Write(ViewData["Fecha"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alumno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
