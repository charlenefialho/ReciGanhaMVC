#pragma checksum "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15efc4d3e2ba9e2be1f5a95b729989c278ab1bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PostoDeColeta_AutenticarPostoDecoleta), @"mvc.1.0.view", @"/Views/PostoDeColeta/AutenticarPostoDecoleta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15efc4d3e2ba9e2be1f5a95b729989c278ab1bca", @"/Views/PostoDeColeta/AutenticarPostoDecoleta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a1fb6c8860a1f6abae4af1cd7760c2d77a5da8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PostoDeColeta_AutenticarPostoDecoleta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReciGanhaMVC.Models.PostoDeColetaViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PostoDeColeta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexCadastroPosto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
  
    ViewBag.Title = "AutenticarPostoDeColeta";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"limiter-2\">\r\n            <div class=\"container-login100-2\">\r\n");
#nullable restore
#line 8 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                 if (@TempData["Mensagem"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-succes\" role=\"alert\">\r\n                    ");
#nullable restore
#line 11 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
               Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!--Configuração para exibir mensagem de erro -->\r\n");
#nullable restore
#line 15 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                 if (@TempData["MensagemErro"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\" role=\"alert\">\r\n                        ");
#nullable restore
#line 18 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 20 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"wrap-login100-2\">\r\n\r\n");
#nullable restore
#line 23 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                     using (Html.BeginForm("Autenticar", "PostoDeColeta",FormMethod.Post,  new {@class="login100-form-2 validate-form"} ))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"login100-form-title-2\">\r\n                           LOGIN\r\n                        </span>\r\n");
            WriteLiteral("                        <div class=\"wrap-input100 validate-input\">\r\n                            ");
#nullable restore
#line 31 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                       Write(Html.TextBoxFor(model => model.CNPJ, new {@placeholder="CNPJ",@class="input100", @name ="CNPJ", @onkeypress="$(this).mask('00.000.000/0000-00')"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <span class=""focus-input100""></span>
                            <span class=""symbol-input100"">
                                <i class=""fa fa-envelope"" aria-hidden=""true""></i>
                            </span>
                        </div>
");
            WriteLiteral("                        <div class=\"wrap-input100 validate-input\" data-validate = \"Password is required\">\r\n                            ");
#nullable restore
#line 39 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                       Write(Html.PasswordFor(model => model.PasswordString, new{@placeholder="Senha", @class="input100"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <span class=""focus-input100""></span>
                            <span class=""symbol-input100"">
                                <i class=""fa fa-lock"" aria-hidden=""true""></i>
                            </span>
                        </div>
");
            WriteLiteral("                        <div class=\"container-login100-form-btn-2\">\r\n                            <button class=\"login100-form-btn-2\">\r\n                                Logar\r\n                            </button>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"flex-col\">\r\n                            <span class=\"link-2\" >\r\n                                Não  possui uma conta?\r\n                            </span>\r\n    \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15efc4d3e2ba9e2be1f5a95b729989c278ab1bca9273", async() => {
                WriteLiteral("\r\n                                Cadastre-se\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 61 "C:\ReciGanhaMVC\Views\PostoDeColeta\AutenticarPostoDecoleta.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReciGanhaMVC.Models.PostoDeColetaViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
