#pragma checksum "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaddd365cbf13f8c352fd5b4f5ea3edf943054cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
#line 1 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\_ViewImports.cshtml"
using Platzi_Asp_Net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\_ViewImports.cshtml"
using Platzi_Asp_Net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaddd365cbf13f8c352fd5b4f5ea3edf943054cb", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c3a6a73966ec9128d523e46407006ddd567609", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Escuela\r\n");
#nullable restore
#line 2 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = " Informacion Escuela ";
    Layout = "Simple";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Escuela ");
#nullable restore
#line 9 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h2>Nombre:");
#nullable restore
#line 10 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
          Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n    <h3>Tipo Escuela: ");
#nullable restore
#line 11 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
                 Write(Model.TipoEscuela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <addres>\r\n        <p>Direccción: ");
#nullable restore
#line 13 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
                  Write(Model.Dirección);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <P>Pais:");
#nullable restore
#line 14 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
           Write(Model.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</P>\r\n         <P>Ciudad:");
#nullable restore
#line 15 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
              Write(Model.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</P>\r\n    </addres>\r\n    <p><strong>Año de fundacion ");
#nullable restore
#line 17 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
                           Write(Model.AñoDeCreación);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></p>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n\r\n    <p><i>");
#nullable restore
#line 20 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
     Write(ViewBag.cosadinamica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n    <p><i>");
#nullable restore
#line 21 "C:\Users\Raziel214\Documents\GitHub\Platzi-Asp-Net-core\Views\Escuela\Index.cshtml"
     Write(ViewData["cosadinamica"]);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
