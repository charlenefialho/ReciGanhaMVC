#pragma checksum "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b458ad8426bb5a068445308da1b641b102a702"
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
using ReciGanhaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ReciGanhaMVC\Views\_ViewImports.cshtml"
using ReciGanhaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b458ad8426bb5a068445308da1b641b102a702", @"/Views/Clientes/CadastrarCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a1fb6c8860a1f6abae4af1cd7760c2d77a5da8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clientes_CadastrarCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReciGanhaMVC.Models.ClienteViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
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
<div class=""content"">
    <div class=""container"">
        <div class=""row greenBox"">
            <div class=""col-md-6 "">
                <img class=""img-fluid img-cadastro"" id=""logo"" src=""assets/img/Logo.png"" alt=""Logo ReciGanha"">
            </div>
            <div class=""col-md-6 contents"">
                <div class=""row justify-content-center"">
                    <div class=""col-md-8 darkgreenbox"">
                        <div class=""mb-4"">
                            <h3>Sign In</h3>
                            <p class=""mb-4"">Lorem ipsum dolor sit amet elit. Sapiente sit aut eos consectetur
                                adipisicing.</p>
                        </div>

");
#nullable restore
#line 36 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                         using (Html.BeginForm("Registrar", "Clientes", FormMethod.Post))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <!--É um método que gera e insere no HTML gerado na view um código para evitar que se falsifique o envio de dados para o servidor.-->\r\n");
            WriteLiteral("                            <div class=\"form-group first\">\r\n                                <label for=\"NomeCliente\">nome</label>\r\n                                    ");
#nullable restore
#line 43 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                               Write(Html.TextBoxFor(model => model.NomeCliente, new { htmlAttributes = new { @class = "form-control", @name = "NomeCliente"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group middle mb-4\">\r\n                                <label for=\"EmailCliente\">email</label>\r\n                                    ");
#nullable restore
#line 47 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                               Write(Html.TextBoxFor(model => model.EmailCliente, new { htmlAttributes = new { @class = "form-control", @name = "EmailCliente", @type="email"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
            WriteLiteral("                            <div class=\"form-group last mb-4\">\r\n                                <label for=\"senha\">senha</label>\r\n                                ");
#nullable restore
#line 52 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
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
#line 56 "C:\ReciGanhaMVC\Views\Clientes\CadastrarCliente.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80b458ad8426bb5a068445308da1b641b102a7028526", async() => {
                WriteLiteral("\r\n                            \r\n                            <input type=\"submit\" value=\"Log In\" class=\"btn btn-block btn-primary\">\r\n                            \r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
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
            WriteLiteral("                               Exemplo de Link (Texto, View, Controller) \r\n                                    Html.ActionLink(\"Retornar\", \"index\", \"Home\", null, new {  class = \"btn text-white rounded-pill\" })\r\n                            </div>-->\r\n");
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
