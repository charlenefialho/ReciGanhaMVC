#pragma checksum "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65aac39a8748ceda4e1ae7cc9e570514133fae28"
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
#line 1 "D:\charlene\ReciGanhaMVC\Views\_ViewImports.cshtml"
using Reciganha_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\charlene\ReciGanhaMVC\Views\_ViewImports.cshtml"
using Reciganha_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65aac39a8748ceda4e1ae7cc9e570514133fae28", @"/Views/Clientes/CadastrarCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f391a692dd10c4bb7bd605856282a01edc4168", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clientes_CadastrarCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reciganha_MVC.Models.ClienteViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Clientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Namespace da classe de Modelo-->\r\n");
            WriteLiteral("\r\n\r\n<!-- Erro not found-->\r\n\r\n\r\n<!-- Titulo da view-->\r\n");
#nullable restore
#line 9 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
  
    ViewBag.Title = "Registrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Configuração da mensagem Temporaria-->\r\n");
#nullable restore
#line 14 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 17 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 19 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"








<div class=""background container-fluid  d-flex flex-sm-wrap "">
        <section class=""darkgreenbox row mx-auto w-75 "">
                <div class=""col-md-6 col-sm-12 text-center border border-dark d-flex flex-column  justify-content-around"">
                     <!--LOGO-->
                        <div><img class=""w-25"" id=""logo"" src=""wwwroot/assets/img/Logo.png"" alt=""Logo ReciGanha""></div>

                        <h1 class=""bem-vindo mt-0"" >BEM-VINDO</h1>

                        <p id=""contaExist"" >Já possui uma conta?</p>
");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65aac39a8748ceda4e1ae7cc9e570514133fae286116", async() => {
                WriteLiteral("<button type=\"button\" class=\"entrar  btn text-white rounded-pill \">Entrar</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"                </div>
                <div class=""cadastro col-md-6 text-center border border-dark d-flex flex-column"">
                   <h1 id=""h1"">Crie sua conta</h1>
                            <h3 id=""h3"">Preencha seus dados</h3>
                            <!--método que será chamado/ controller/tipo Post-->
");
#nullable restore
#line 46 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                             using(Html.BeginForm("Registrar", "Clientes", FormMethod.Post))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"form-group\">\r\n                                    <img");
            BeginWriteAttribute("alt", "  alt=\"", 1791, "\"", 1798, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon\" src=\"https://cdn-icons-png.flaticon.com/512/1828/1828439.png\">\r\n                                    <span>Nome:</span>\r\n                                    <!--Campo TextBox -->\r\n                                    ");
#nullable restore
#line 53 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                               Write(Html.EditorFor(model => model.NomeCliente, new { htmlAttributes = new { @class = "form-control", @name = "nome"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
            WriteLiteral("                                <div class=\"form-group\">\r\n                                    <img");
            BeginWriteAttribute("alt", "  alt=\"", 2286, "\"", 2293, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon\" src=\"https://cdn-icons-png.flaticon.com/512/4213/4213922.png\">\r\n                                    <span>Email:</span>   \r\n                                    ");
#nullable restore
#line 59 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                               Write(Html.EditorFor(model => model.EmailCliente, new { htmlAttributes= new{ @class = "form-control", @name = "email"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    \r\n                                </div>\r\n");
            WriteLiteral("                                <div class=\"form-group\">\r\n                                    <img");
            BeginWriteAttribute("alt", "  alt=\"", 2763, "\"", 2770, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon\" src=\"https://cdn-icons-png.flaticon.com/512/102/102643.png\">\r\n                                    <span> Senha: </span>\r\n                                        ");
#nullable restore
#line 66 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                                   Write(Html.PasswordFor(model => model.PasswordString, new {htmlAttributes = new {@class = "form-control", @name = "senha"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div> \r\n                                    <input type=\"submit\" value=\"Cadastrar\" class=\"cadastrar btn text-white rounded-pill\"/>\r\n                                </div> \r\n");
#nullable restore
#line 71 "D:\charlene\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
        </section>
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
            WriteLiteral("               Exemplo de Link (Texto, View, Controller) \r\n                                    Html.ActionLink(\"Retornar\", \"index\", \"Home\", null, new {  class = \"btn text-white rounded-pill\" })\r\n                            </div>-->\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reciganha_MVC.Models.ClienteViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
