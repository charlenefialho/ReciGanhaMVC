#pragma checksum "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1b45266d61f2743211088bc728661c0d589f07"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1b45266d61f2743211088bc728661c0d589f07", @"/Views/PostoDeColeta/RegistrarPostoDeColeta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a1fb6c8860a1f6abae4af1cd7760c2d77a5da8", @"/Views/_ViewImports.cshtml")]
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
#line 3 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
  
    ViewBag.Title = "RegistrarPostoDeColeta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-succes\" role=\"alert\">\r\n    ");
#nullable restore
#line 10 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Configuração da mensagem Temporaria-->\r\n");
#nullable restore
#line 14 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 17 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main id=\"viewRegistrarPosto\">\r\n    <article id=\"Registro\">\r\n");
#nullable restore
#line 23 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
         using (Html.BeginForm("Registrar", "PostoDeColeta",FormMethod.Post,  new {hmlAttributes= new {@id="formRegistro"} }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"nomePosto\">Nome do Posto</label>\r\n                ");
#nullable restore
#line 28 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.TextBoxFor(model => model.NomePosto, new {hmlAttributes= new {@class = "form-control", @name ="nomePosto"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"CNPJ\">CNPJ</label>\r\n                ");
#nullable restore
#line 33 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.TextBoxFor(model => model.CNPJ, new {hmlAttributes= new { @class = "form-control",@name ="CNPJ", @maxlength="14", @id="CNPJ"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"senha\">Senha</label>\r\n                ");
#nullable restore
#line 38 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.PasswordFor(model => model.PasswordString, new {hmlAttributes= new {@class = "form-control", @name ="senha"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Plastico\">Plástico</label>\r\n                ");
#nullable restore
#line 42 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.CheckBoxFor(model => model.SelecionadoPlastico, new {hmlAttributes= new {@id="Plastico", @name ="Plastico"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                 <label for=\"Metal\">Metal</label>\r\n                ");
#nullable restore
#line 45 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.CheckBoxFor(model => model.SelecionadoMetal , new {hmlAttributes= new {@id="Metal", @name ="Metal"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                 <label for=\"Papel\">Papel</label>\r\n                ");
#nullable restore
#line 48 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.CheckBoxFor(model => model.SelecionadoPapel , new {hmlAttributes= new {@id="Papel", @name ="Papel"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                 <label for=\"Vidro\">Vidro</label>\r\n                ");
#nullable restore
#line 51 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
           Write(Html.CheckBoxFor(model => model.SelecionadoVidro , new {hmlAttributes= new {@id="Vidro", @name ="Vidro"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div>\r\n                <button type=\"submit\" value=\"Cadastrar\" class=\"cadastrar btn text-white rounded-pill\" id=\"botaoDialog\">Cadastrar</button>\r\n            </div>\r\n");
            WriteLiteral("            <div>\r\n                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b1b45266d61f2743211088bc728661c0d589f079733", async() => {
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
#line 65 "C:\ReciGanhaMVC\Views\PostoDeColeta\RegistrarPostoDeColeta.cshtml"
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
