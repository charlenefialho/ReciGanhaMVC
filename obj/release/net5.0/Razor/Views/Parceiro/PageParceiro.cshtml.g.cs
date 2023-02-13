#pragma checksum "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d122888abac54c7fbb662b539592e5faeb4ab374"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d122888abac54c7fbb662b539592e5faeb4ab374", @"/Views/Parceiro/PageParceiro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a1fb6c8860a1f6abae4af1cd7760c2d77a5da8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Parceiro_PageParceiro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReciGanhaMVC.Models.ParceiroViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Namespace da classe de Modelo-->\r\n");
            WriteLiteral(@"


<style>
  #tituloParceiro{
    color: white;
  }

  #parceiros-cad{
    background-color: #003829;
  }

  .textolateral{
    color: #003829;
  }

  .footer-parceiros{
    display:flex;
    background-color: #003829;
  }

  .footerFluid{
    padding-left: 0px;
    padding-right: 0px;
    height: 3vh;
  }

  #imagens{
    display: flex;
    justify-content: space-around;
    padding-top: 4vh;
    padding-left: 15vw;
    flex-wrap: wrap;
  }

  #bkimg{
      width: 159px;
      height: 156px;
      margin-right: 15vw;
  }

  .ajustepd{
    padding-top: 3vh;
  }

  #imgparceiro{
    width: 342px;
    padding-top: 3%;
  }
</style>
<!-- Erro not found-->


<!-- Titulo da view-->
");
#nullable restore
#line 57 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
  
    ViewBag.Title = "ParceiroHome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Configuração da mensagem Temporaria-->\r\n");
#nullable restore
#line 62 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 65 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""container"">
      <div class=""limiter"">
		<div class=""container-login100"">
			<div class=""wrap-login100"" id=""parceiros-cad"">
          <div class=""login100-pic js-tilt"" id=""imgparceiro"" data-tilt>
            <img src=""assets/img/imageParceiroDois.png"" alt=""mão parceria"">
          </div>

");
#nullable restore
#line 78 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
           using (Html.BeginForm("Registrar", "Parceiro", FormMethod.Post, new{@class="login100-form validate-form"}))
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--É um método que gera e insere no HTML gerado na view um código para evitar que se falsifique o envio de dados para o servidor.-->\r\n");
#nullable restore
#line 81 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"login100-form-title\" id=\"tituloParceiro\">\r\n              SEJA ASSOCIADA\r\n            </h3>\r\n            <div class=\"wrap-input100 validate-input\" data-validate = \"nome de usuario requerido\">\r\n              ");
#nullable restore
#line 86 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
         Write(Html.TextBoxFor(model => model.NomeParceiro, new { @class = "form-control",@placeholder="Nome da empresa", @name = "nome"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"wrap-input100 validate-input\" data-validate = \"Valid email is required: ex@abc.xyz\">\r\n              ");
#nullable restore
#line 89 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
         Write(Html.TextBoxFor(model => model.CnpjParceiro, new {@class = "form-control", @placeholder="CNPJ",@name = "cnpj"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              <span class=\"focus-input100\"></span>\r\n            </div>\r\n            <div class=\"wrap-input100 validate-input\" data-validate = \"Password is required\">\r\n              ");
#nullable restore
#line 93 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
         Write(Html.TextBoxFor(model => model.EmailParceiro, new {@class = "form-control", @name = "EmailParceiro", @placeholder="EmailParceiro"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              <span class=\"focus-input100\"></span>\r\n            </div>\r\n");
            WriteLiteral("                    <div class=\"wrap-input100 validate-input\" data-validate = \"Password is required\">\r\n              ");
#nullable restore
#line 98 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
         Write(Html.TextBoxFor(model => model.PasswordString, new{@class = "form-control", @name = "senha", @placeholder="Senha",@type="senha"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              <span class=\"focus-input100\"></span>\r\n            </div>\r\n            <div class=\"container-login100-form-btn\">\r\n              <button class=\"login100-form-btn\">\r\n                Cadastrar\r\n              </button>\r\n            </div>\r\n");
#nullable restore
#line 106 "C:\Users\chazi\siteTCC\ReciGanhaMVC\Views\Parceiro\PageParceiro.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			</div>
		</div>
</div>
</div>

<div class=""container-fluid footerFluid"">
  <footer class=""footer-parceiros"">
    <div id=""imagens"">

        <a href=""https://www.burgerking.com.br/"" target=""blank""><img src=""assets/img/logoBK-removebg-preview.png"" class=""d-flex""  id=""bkimg""></a>
      
        <a href=""https://www.cea.com.br/?utm_source=delorean&utm_medium=minhacea&utm_campaign=poupenaweb22&gclid=Cj0KCQiAkMGcBhCSARIsAIW6d0BleoEFJcN7USAI5OA9FHeBmpiPFqBTQPBbA26FTnCLXoTY0f1JMrQaAuzTEALw_wcB"" target=""blank""><img src=""assets/img/c_a-removebg-preview.png"" class=""ajustepd d-flex w-25"" ></a>

         <a href=""https://developer.mozilla.org/pt-BR/docs/Learn/JavaScript/First_steps/What_is_JavaScript"" target=""blank""><img src=""assets/img/espaco-removebg-preview.png"" class=""ajustepd d-flex w-25"" ></a>

  </div>
  </footer>
</div>



");
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
