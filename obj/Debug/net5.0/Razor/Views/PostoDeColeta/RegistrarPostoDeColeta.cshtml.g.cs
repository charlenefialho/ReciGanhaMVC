#pragma checksum "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca80bb28ba2b0af654d6d0598f82b8dc7185354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PostoDeColeta_RegistrarPostoDeColeta), @"mvc.1.0.view", @"/Views/PostoDeColeta/RegistrarPostoDeColeta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca80bb28ba2b0af654d6d0598f82b8dc7185354", @"/Views/PostoDeColeta/RegistrarPostoDeColeta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f391a692dd10c4bb7bd605856282a01edc4168", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PostoDeColeta_RegistrarPostoDeColeta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReciGanhaMVC.Models.PostoDeColetaViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AutenticarPostoDeColeta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PostoDeColeta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexAutenticarPosto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
  
    ViewBag.Title = "RegistrarPostoDeColeta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-succes\" role=\"alert\">\r\n    ");
#nullable restore
#line 10 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Configuração da mensagem Temporaria-->\r\n");
#nullable restore
#line 14 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 17 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 19 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main id=\"viewRegistrarPosto\">\r\n    <article id=\"Registro\">\r\n");
#nullable restore
#line 23 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
         using (Html.BeginForm("Registrar", "PostoDeColeta",FormMethod.Post,  new {hmlAttributes= new {@id="formRegistro"} }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"nomePosto\">Nome do Posto</label>\r\n                ");
#nullable restore
#line 28 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.TextBoxFor(model => model.NomePosto, new {hmlAttributes= new {@class = "form-control", @name ="nomePosto"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"CNPJ\">CNPJ</label>\r\n                ");
#nullable restore
#line 33 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.EditorFor(model => model.CNPJ, new {hmlAttributes= new {@class = "form-control", @name ="CNPJ"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"senha\">Senha</label>\r\n                ");
#nullable restore
#line 38 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.PasswordFor(model => model.PasswordString, new {hmlAttributes= new {@class = "form-control", @name ="senha"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div>\r\n                <button type=\"submit\" value=\"Cadastrar\" class=\"cadastrar btn text-white rounded-pill\">Cadastrar</button>\r\n            </div>\r\n");
            WriteLiteral("            <div>\r\n                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ca80bb28ba2b0af654d6d0598f82b8dc71853548208", async() => {
                WriteLiteral("\r\n                     Ja é cadastrado?Faça o login\r\n                    ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n");
#nullable restore
#line 52 "D:\charlene\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </article>\r\n</main>\r\n");
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
