#pragma checksum "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3eca20523069fc337a6349d55a8885772ef5f3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parceiro_PageParceiro), @"mvc.1.0.view", @"/Views/Parceiro/PageParceiro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3eca20523069fc337a6349d55a8885772ef5f3f", @"/Views/Parceiro/PageParceiro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f391a692dd10c4bb7bd605856282a01edc4168", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Parceiro_PageParceiro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReciGanhaMVC.Models.ParceiroViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
  
    ViewBag.Title = "ParceiroHome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-succes\" role=\"alert\">\r\n    ");
#nullable restore
#line 10 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Configuração da mensagem Temporaria-->\r\n");
#nullable restore
#line 14 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 17 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 19 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"background container-fluid  d-flex flex-sm-wrap \">\r\n");
#nullable restore
#line 22 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
     if (@TempData["Mensagem"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-succes\" role=\"alert\">\r\n            ");
#nullable restore
#line 25 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
       Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <section class=""darkgreenbox row mx-auto w-75 "">
                <div class=""col-md-6 col-sm-12 text-center border border-dark d-flex flex-column  justify-content-around"">
                     <!--LOGO-->
                        <div><img class=""w-25"" id=""logo"" src=""wwwroot/assets/img/Logo.png"" alt=""Logo ReciGanha""></div>

                        <h1 class=""bem-vindo "" >Prazer, somos a Parceiros Associados</h1>

                        <p id=""contaExist"" >Acreditamos em transformar o mundo em um lugar melhor e mais sustentável.
                            Mas mudar o mundo não é algo que se faça sozinho, não é mesmo?! Com tecnologias sociais e soluções personalizadas
                            para nossos parceiros com foco no desenvolvimento sustentável das comunidades e territórios, acreditamos que podemos
                            contribuir um pouco mais juntando nossas forças!

                        </p>
                </div>
                <div class=""cadastro col-md-6 text-");
            WriteLiteral("center border border-dark d-flex flex-column\">\r\n                   <h1 id=\"h1\">Seja nosso parceiro!</h1>\r\n                            <h3 id=\"h3\">Preencha seus dados</h3>\r\n                            <!--método que será chamado/ controller/tipo Post-->\r\n");
#nullable restore
#line 45 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
                             using(Html.BeginForm("Registrar", "Clientes", FormMethod.Post))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--É um método que gera e insere no HTML gerado na view um código para evitar que se falsifique o envio de dados para o servidor.-->\r\n");
            WriteLiteral("                                <div class=\"form-group\">\r\n                                    <img");
            BeginWriteAttribute("alt", "  alt=\"", 2335, "\"", 2342, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon\"");
            BeginWriteAttribute("src", " src=\"", 2356, "\"", 2362, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label for=\"nome\">Empresa</label>\r\n                                    ");
#nullable restore
#line 52 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
                               Write(Html.TextBoxFor(model => model.NomeParceiro, new { htmlAttributes = new { @class = "form-control", @name = "nome"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
            WriteLiteral("                                <div class=\"form-group\">\r\n                                    <img");
            BeginWriteAttribute("alt", "  alt=\"", 2733, "\"", 2740, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon\"");
            BeginWriteAttribute("src", " src=\"", 2754, "\"", 2760, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label for=\"email\">CNPJ</label>  \r\n                                    ");
#nullable restore
#line 58 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
                               Write(Html.TextBoxFor(model => model.CnpjParceiro, new { htmlAttributes= new{ @class = "form-control", @name = "cnpj", @type="cnpj"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    \r\n                                </div>\r\n");
            WriteLiteral("                                <div> \r\n                                    <button type=\"submit\" value=\"Cadastrar\" class=\"cadastrar btn text-white rounded-pill\">Cadastrar</button>\r\n                                </div> \r\n");
#nullable restore
#line 65 "D:\TCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n        </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReciGanhaMVC.Models.ParceiroViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591