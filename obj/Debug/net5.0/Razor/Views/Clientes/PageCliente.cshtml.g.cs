#pragma checksum "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d54ecbd3cdbb6fb993e4f99b275acbeda2ecd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_PageCliente), @"mvc.1.0.view", @"/Views/Clientes/PageCliente.cshtml")]
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
#line 1 "D:\TCC\ReciGanhaMVC\Views\_ViewImports.cshtml"
using Reciganha_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TCC\ReciGanhaMVC\Views\_ViewImports.cshtml"
using Reciganha_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d54ecbd3cdbb6fb993e4f99b275acbeda2ecd1", @"/Views/Clientes/PageCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f391a692dd10c4bb7bd605856282a01edc4168", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clientes_PageCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReciGanhaMVC.Models.ClienteColetaViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- IEnumerable<ReciGanhaMVC.Models.ClienteColetaViewModel> -->\r\n\r\n    <!--ReciGanhaMVC.Models.ClienteViewModel-->\r\n");
#nullable restore
#line 6 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
  
    ViewBag.Title = "ClienteHome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--Configuração da mensagem Temporaria-->\r\n\r\n\r\n<main id=\"viewHomeCliente\">\r\n    <article id=\"acoesAmbiente\">\r\n");
#nullable restore
#line 16 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
         if (@TempData["Mensagem"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-succes\" role=\"alert\">\r\n            ");
#nullable restore
#line 19 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
       Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
         if (@TempData["MensagemErro"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">\r\n                ");
#nullable restore
#line 25 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
           Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 27 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <table>\r\n            <tr>             \r\n                <td>\r\n                    <section id=\"listagemColetas\">\r\n");
#nullable restore
#line 33 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
                         foreach(var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 36 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IdColeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
                               Write(Html.DisplayFor(modelItem => item.dataColeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
                               Write(Html.DisplayFor(modelItem => item.resultadoDePontos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 40 "D:\TCC\ReciGanhaMVC\Views\Clientes\PageCliente.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </section>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </article>\r\n</main>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReciGanhaMVC.Models.ClienteColetaViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
