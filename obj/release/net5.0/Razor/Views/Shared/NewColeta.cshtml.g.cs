#pragma checksum "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ee96d69808c7391a0202baccf3528f432516774"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NewColeta), @"mvc.1.0.view", @"/Views/Shared/NewColeta.cshtml")]
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
#line 1 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\_ViewImports.cshtml"
using ReciGanhaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\_ViewImports.cshtml"
using ReciGanhaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee96d69808c7391a0202baccf3528f432516774", @"/Views/Shared/NewColeta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a1fb6c8860a1f6abae4af1cd7760c2d77a5da8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_NewColeta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReciGanhaMVC.Models.NewColetaViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
  
  ViewBag.Title = "Inclusão de Coleta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<main id=\"mainColeta\">\r\n  <article id=\"list-cards\">\r\n");
#nullable restore
#line 13 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
     using (Html.BeginForm("Insert", "Coleta", FormMethod.Post, new{@class="form-coleta"}))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <!--Configuração da mensagem Temporaria-->\r\n");
#nullable restore
#line 16 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       if (@TempData["MensagemErro"] != null)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\">\r\n          ");
#nullable restore
#line 19 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
     Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       if (@TempData["Mensagem"] != null)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\">\r\n          ");
#nullable restore
#line 25 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
     Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      <!--<form action=\"POST\">-->\r\n      <section id=\"botao\">\r\n        <button type=\"submit\" class=\"btn btn-success btnInserir\">Inserir coleta</button>\r\n        ");
#nullable restore
#line 33 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
   Write(Html.TextBoxFor(model => model.EmailCliente, new { @class = "form-control input-coleta" , @placeholder="Digite o email do cliente"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </section>\r\n");
            WriteLiteral(@"      <section class=""cards-coleta"">
        <div class=""card card-material"">
          <img href=""assets/plastico.jpg"" class=""card-img-top "" alt=""garrafas de plastico"">
          <div class=""card-body"">
            <h4 class=""card-title text-dark"">Plastico</h4>
            <span class=""TextPesoColeta"">Insira o peso em Kg</span>
            <!--<input type=""number"" name=""Peso"" id=""plastico"">-->
            ");
#nullable restore
#line 43 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       Write(Html.TextBoxFor(model => model.Plastico, new  { @class = "form-control input-coleta" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
          </div>
        </div>

        <div class=""card card-material"">
          <img src=""assets/img/metal.jpg"" class=""card-img-top "" alt=""latas de refrigerante"">
          <div class=""card-body"">
            <h4 class=""card-title text-dark"">Metal</h4>
            <span class=""TextPesoColeta"" >Insira o peso em Kg</span>
            ");
#nullable restore
#line 52 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       Write(Html.TextBoxFor(model => model.Metal, new  {@class = "form-control input-coleta"  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!--<input type=""number"" name=""Peso"" id=""aluminio"">-->
          </div>
        </div>

        <div class=""card card-material"">
          <img src=""assets/img/papel.jpg"" class=""card-img-top "" alt=""papel"">
          <div class=""card-body"">
            <h4 class=""card-title text-dark"">Papel</h4>
            <span class=""TextPesoColeta"">Insira o peso em Kg</span>
            ");
#nullable restore
#line 62 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       Write(Html.TextBoxFor(model => model.Papel, new {@class = "form-control input-coleta" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!--<input type=""number"" name=""Peso"" id=""aluminio"">-->
          </div>
        </div>

        <div class=""card card-material"">
          <img src=""assets/img/vidro.jpg"" class=""card-img-top "" alt=""caixa com vidro"">
          <div class=""card-body"">
            <h4 class=""card-title text-dark"">Vidro</h4>
            <span class=""TextPesoColeta"">Insira o peso em Kg</span>
            ");
#nullable restore
#line 72 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       Write(Html.TextBoxFor(model => model.Vidro, new { @class = "form-control input-coleta vidro" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--<input type=\"number\" name=\"Peso\" id=\"aluminio\">-->\r\n          </div>\r\n        </div>\r\n\r\n      </section>\r\n      <!--</form>-->\r\n");
#nullable restore
#line 79 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <!--<div class=\"form-group\">\r\n                            <span>tipo:</span>\r\n    ");
#nullable restore
#line 85 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
Write(Html.TextBoxFor(model => model.TipMat, new {@type= "number", @class="form-control", @min = "0"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                          </div>\r\n                        <div class=\"form-group\">\r\n                            <span>Peso:</span>\r\n    ");
#nullable restore
#line 90 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
Write(Html.TextBoxFor(model => model.Pes, new {@type= "number", @class="form-control", @min = "0"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                  </div>\r\n                    </div>\r\n                </div>\r\n                      <div class=\"form-group\">\r\n                            <span>tipo:</span>\r\n    ");
#nullable restore
#line 98 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
Write(Html.TextBoxFor(model => model.TipMat , new {@type= "number", @class="form-control", @min = "0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                          </div>\r\n                      <div class=\"form-group\">\r\n                              <span>Peso:</span>\r\n    ");
#nullable restore
#line 103 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
Write(Html.TextBoxFor(model => model.Pes, new {@type= "number", @class="form-control", @min = "0"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n\r\n\r\n\r\n\r\n  </article>\r\n\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReciGanhaMVC.Models.NewColetaViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
