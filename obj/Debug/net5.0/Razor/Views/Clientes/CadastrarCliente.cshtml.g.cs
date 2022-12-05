#pragma checksum "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "221b507dba11513c55bbcba95dd55169e9374984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_CadastrarCliente), @"mvc.1.0.view", @"/Views/Clientes/CadastrarCliente.cshtml")]
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
#line 1 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\_ViewImports.cshtml"
using ReciGanhaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\_ViewImports.cshtml"
using ReciGanhaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221b507dba11513c55bbcba95dd55169e9374984", @"/Views/Clientes/CadastrarCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a1fb6c8860a1f6abae4af1cd7760c2d77a5da8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clientes_CadastrarCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReciGanhaMVC.Models.ClienteViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Namespace da classe de Modelo-->\r\n");
            WriteLiteral("\r\n\r\n<!-- Erro not found-->\r\n\r\n\r\n<!-- Titulo da view-->\r\n");
#nullable restore
#line 9 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
  
    ViewBag.Title = "Registrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Configuração da mensagem Temporaria-->\r\n");
#nullable restore
#line 14 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 17 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""container"">
        <div class=""row greenBoxCadastro"">
            <div class=""col-md-6 "">
                <img class=""img-fluid img-cadastro"" id=""logo"" src=""assets/img/Logo.png"" alt=""Logo ReciGanha"">
            </div>
            <div class=""col-md-6 contents"">
                <div class=""row justify-content-center"">
                    <div class=""col-md-8 darkgreenboxCadastro"">
                        <div class=""mb-4"">
                            <h3>Crie a sua conta</h3>
                            <p class=""mb-4"">Preencha seus dados</p>
                        </div>

");
#nullable restore
#line 35 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                         using (Html.BeginForm("Registrar", "Clientes", FormMethod.Post))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <!--É um método que gera e insere no HTML gerado na view um código para evitar que se falsifique o envio de dados para o servidor.-->\r\n");
            WriteLiteral("                            <div class=\"form-group nome\">\r\n                                <label for=\"NomeCliente\">nome</label>\r\n                                    ");
#nullable restore
#line 42 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                               Write(Html.TextBoxFor(model => model.NomeCliente, new { htmlAttributes = new { @class = "form-control", @name = "NomeCliente"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group email mb-4\">\r\n                                <label for=\"EmailCliente\">email</label>\r\n                                    ");
#nullable restore
#line 46 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                               Write(Html.TextBoxFor(model => model.EmailCliente, new { htmlAttributes = new { @class = "form-control", @name = "EmailCliente", @type="email"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
            WriteLiteral("                            <div class=\"form-group senha mb-4\">\r\n                                <label for=\"senha\">senha</label>\r\n                                ");
#nullable restore
#line 51 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                           Write(Html.PasswordFor(model => model.PasswordString, new {htmlAttributes = new {@class = "form-control",@name = "senha"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <button type=""submit"" value=""Cadastrar"" class=""cadastrar btn text-white rounded-pill"">Cadastrar</button>
                            <span class=""d-block text-left my-4 text-muted"">— or login with —</span>
");
#nullable restore
#line 55 "C:\Users\AttTCC0512\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</div>














<!--<form action=""/Cliente/Autenticar"" method=""post"">
                                <div class=""form-group"">
                                    <input type=""text"" id=""nome"" name=""nome"" value=""Cliente.NomeCliente"">
                                    <label for=""nome"">Nome:</label>
                                </div>
                            </form>

                            <div class=""form-group"">
                                <img class=""icon"" [src]=""iconEmail"" alt="""">
                                <span>Email:</span>
                                <input type=""text"">
                            </div>

                            <div class=""form-group"">
                                <img class=""icon"" [src]=""iconSenha"" alt="""">
                                <span>Senha:</span>
                                <input type=""password"">

  ");
            WriteLiteral("                             Exemplo de Link (Texto, View, Controller) \r\n                                    Html.ActionLink(\"Retornar\", \"index\", \"Home\", null, new {  class = \"btn text-white rounded-pill\" })\r\n                            </div>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReciGanhaMVC.Models.ClienteViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
