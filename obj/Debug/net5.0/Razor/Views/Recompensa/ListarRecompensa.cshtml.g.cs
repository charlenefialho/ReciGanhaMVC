#pragma checksum "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3e5216ad22c82e774416df306d3d620c9145b93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recompensa_ListarRecompensa), @"mvc.1.0.view", @"/Views/Recompensa/ListarRecompensa.cshtml")]
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
using ReciGanhaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TCC\ReciGanhaMVC\Views\_ViewImports.cshtml"
using ReciGanhaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e5216ad22c82e774416df306d3d620c9145b93", @"/Views/Recompensa/ListarRecompensa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a1fb6c8860a1f6abae4af1cd7760c2d77a5da8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Recompensa_ListarRecompensa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReciGanhaMVC.Models.RecompensaViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
  
    ViewBag.Title = "Recompensas" ; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"background\">\r\n");
#nullable restore
#line 8 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
 if (@TempData["CodigoRecompensa"] != null)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""modal"" tabindex=""-1"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Código</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    
                        <p>");
#nullable restore
#line 22 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
                      Write(TempData["CodigoRecompensa"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
                </div>
            </div>
            </div>
");
#nullable restore
#line 31 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"container-fluid\">\r\n");
#nullable restore
#line 35 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
         if (@TempData["Mensagem"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-succes\" role=\"alert\">\r\n            ");
#nullable restore
#line 38 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
       Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 39 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!--Configuração para exibir mensagem de erro -->\r\n");
#nullable restore
#line 42 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
         if (@TempData["MensagemErro"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">\r\n                ");
#nullable restore
#line 45 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
           Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 47 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .table{\r\n        margin-top: 15vh;\r\n    }\r\n\r\n    h2{\r\n        margin-top: 5vh;\r\n    }\r\n</style>\r\n\r\n<h2>recompensas</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>");
#nullable restore
#line 63 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
       Write(Html.DisplayNameFor(model => model.idRecompensa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 64 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
       Write(Html.DisplayNameFor(model => model.nomeRecompensa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 65 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
       Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 66 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
       Write(Html.DisplayNameFor(model => model.custodePontos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 67 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
       Write(Html.DisplayNameFor(model => model.qtdeRecomepensas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 70 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 73 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
           Write(Html.DisplayFor(modelItem => item.idRecompensa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 74 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
           Write(Html.DisplayFor(modelItem => item.nomeRecompensa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 75 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
           Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 76 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
           Write(Html.DisplayFor(modelItem => item.custodePontos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 77 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
           Write(Html.DisplayFor(modelItem => item.qtdeRecomepensas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
           Write(Html.ActionLink("Resgatar", "Resgatar", new{ id = item.idRecompensa}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 82 "D:\TCC\ReciGanhaMVC\Views\Recompensa\ListarRecompensa.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReciGanhaMVC.Models.RecompensaViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
