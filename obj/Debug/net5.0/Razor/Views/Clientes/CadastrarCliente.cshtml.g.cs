#pragma checksum "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36baef95be19145b2d5a8bf4db9a27f41ffab859"
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
#line 1 "C:\ReciGanhaMVC\Views\_ViewImports.cshtml"
using Reciganha_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ReciGanhaMVC\Views\_ViewImports.cshtml"
using Reciganha_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36baef95be19145b2d5a8bf4db9a27f41ffab859", @"/Views/Clientes/CadastrarCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f391a692dd10c4bb7bd605856282a01edc4168", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clientes_CadastrarCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reciganha_MVC.Models.ClienteViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/Logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo ReciGanha"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Clientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Namespace da classe de Modelo-->\r\n");
            WriteLiteral("\r\n\r\n<!-- Erro not found-->\r\n\r\n\r\n<!-- Titulo da view-->\r\n");
#nullable restore
#line 9 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
  
    ViewBag.Title = "Registrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Configuração da mensagem Temporaria-->\r\n");
#nullable restore
#line 14 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 17 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""background"">
    <div class=""container"">
        <div class=""darkBox"">
            <div class=""row"">
                <div class=""col-6"">
                    <div class=""center"">
                        <!--LOGO-->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36baef95be19145b2d5a8bf4db9a27f41ffab8596897", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        <h1 id=\"bem-vindo\">BEM-VINDO</h1>\r\n\r\n\r\n                        <p id=\"contaExist\" >Já possui uma conta?</p>\r\n");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36baef95be19145b2d5a8bf4db9a27f41ffab8598302", async() => {
                WriteLiteral("<button type=\"button\" class=\"entrar btn text-white rounded-pill\">Entrar</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"
                        
                    </div><!--FIM CENTER-->
                </div><!--FIM COLUNA-->

                <div class=""col-6"">
                    <div class=""greenBox"">
                        <div class=""center"">
                            <h1 id=""h1"">Crie sua conta</h1>
                            <h3 id=""h3"">Preencha seus dados</h3>
                            <!--método que será chamado/ controller/tipo Post-->
");
#nullable restore
#line 48 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                             using(Html.BeginForm("Registrar", "Clientes", FormMethod.Post))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"form-group\">\r\n                                    <img");
            BeginWriteAttribute("alt", "  alt=\"", 1818, "\"", 1825, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon\" src=\"https://cdn-icons-png.flaticon.com/512/1828/1828439.png\">\r\n                                    <span>Nome:</span>\r\n                                    <!--Campo TextBox -->\r\n                                    ");
#nullable restore
#line 55 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                               Write(Html.EditorFor(model => model.NomeCliente, new { htmlAttributes = new { @class = "form-control", @name = "nome"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
            WriteLiteral("                                <div class=\"form-group\">\r\n                                    <img");
            BeginWriteAttribute("alt", "  alt=\"", 2313, "\"", 2320, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon\" src=\"https://cdn-icons-png.flaticon.com/512/4213/4213922.png\">\r\n                                    <span>Email:</span>   \r\n                                    ");
#nullable restore
#line 61 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                               Write(Html.EditorFor(model => model.EmailCliente, new { htmlAttributes= new{ @class = "form-control", @name = "email"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    \r\n                                </div>\r\n");
            WriteLiteral("                                <div class=\"form-group\">\r\n                                    <img");
            BeginWriteAttribute("alt", "  alt=\"", 2790, "\"", 2797, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon\" src=\"https://cdn-icons-png.flaticon.com/512/102/102643.png\">\r\n                                    <span> Senha: </span>\r\n                                        ");
#nullable restore
#line 68 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                                   Write(Html.PasswordFor(model => model.PasswordString, new {htmlAttributes = new {@class = "form-control", @name = "senha"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div> \r\n                                    <input type=\"submit\" value=\"Cadastrar\" class=\"cadastrar btn text-white rounded-pill\"/>\r\n                                </div> \r\n");
#nullable restore
#line 73 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



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

                               Exemplo de Link (Texto, View, Controller) 
                           ");
            WriteLiteral(@"         Html.ActionLink(""Retornar"", ""index"", ""Home"", null, new {  class = ""btn text-white rounded-pill"" })
                            </div>-->

                        </div><!--FIM CENTER-->
                    </div><!--FIM GREENBOX-->
                </div><!--FIM COLUNA-->
            </div><!--FIM LINHA-->
        </div><!--FIM DARKBOX-->
        
    </div><!--FIM CONTAINER-->
</div><!--FIM BACKGROUND-->





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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reciganha_MVC.Models.ClienteViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
