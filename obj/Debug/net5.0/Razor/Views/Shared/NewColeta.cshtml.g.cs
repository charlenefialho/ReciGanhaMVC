#pragma checksum "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c55337a1b420a07b5f157ead19ae801d8d28dd6e"
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
#line 1 "D:\TCC\ReciGanhaMVC\Views\_ViewImports.cshtml"
using ReciGanhaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TCC\ReciGanhaMVC\Views\_ViewImports.cshtml"
using ReciGanhaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c55337a1b420a07b5f157ead19ae801d8d28dd6e", @"/Views/Shared/NewColeta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a1fb6c8860a1f6abae4af1cd7760c2d77a5da8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_NewColeta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReciGanhaMVC.Models.NewColetaViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
  
  ViewBag.Title = "Inclusão de Coleta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<main id=\"mainColeta\">\r\n  <article id=\"list-cards\">\r\n");
#nullable restore
#line 13 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
     using (Html.BeginForm("Insert", "Coleta", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <!--Configuração da mensagem Temporaria-->\r\n");
#nullable restore
#line 16 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       if (@TempData["MensagemErro"] != null)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\">\r\n          ");
#nullable restore
#line 19 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
     Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 21 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       if (@TempData["Mensagem"] != null)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\">\r\n          ");
#nullable restore
#line 25 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
     Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 27 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      <!--<form action=\"POST\">-->\r\n      <section id=\"botao\">\r\n        <button type=\"submit\" class=\"btnInserir btn btn-primary\">Inserir coleta</button>\r\n        ");
#nullable restore
#line 33 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
   Write(Html.TextBoxFor(model => model.EmailCliente, new { htmlAttributes = new { @class = "form-control" , placeholder="Digite o email do cliente"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </section>\r\n");
            WriteLiteral(@"      <section class=""cards"">
        <div class=""card"">
          <img src=""assets/img/plastico.jpg"" class=""card-img-top "" alt=""garrafas de plastico"">
          <div class=""card-body"">
            <h5 class=""card-title text-dark"">Plastico</h5>
            <select>
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c55337a1b420a07b5f157ead19ae801d8d28dd6e6985", async() => {
                WriteLiteral("\r\n                Plastico\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n            <span>Insira o peso em Kg</span>\r\n            <!--<input type=\"number\" name=\"Peso\" id=\"plastico\">-->\r\n            ");
#nullable restore
#line 48 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       Write(Html.TextBoxFor(model => model.Plastico, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
          </div>
        </div>

        <div class=""card"">
          <img src=""assets/img/metal.jpg"" class=""card-img-top "" alt=""latas de refrigerante"">
          <div class=""card-body"">
            <h5 class=""card-title text-dark"">Metal</h5>
            <select>
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c55337a1b420a07b5f157ead19ae801d8d28dd6e8923", async() => {
                WriteLiteral("\r\n                Metal\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n            <span>Insira o peso em Kg</span>\r\n            ");
#nullable restore
#line 62 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       Write(Html.TextBoxFor(model => model.Metal, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!--<input type=""number"" name=""Peso"" id=""aluminio"">-->
          </div>
        </div>

        <div class=""card"">
          <img src=""assets/img/papel.jpg"" class=""card-img-top "" alt=""papel"">
          <div class=""card-body"">
            <h5 class=""card-title text-dark"">Papel</h5>
            <select>
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c55337a1b420a07b5f157ead19ae801d8d28dd6e10837", async() => {
                WriteLiteral("\r\n                Papel\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n            <span>Insira o peso em Kg</span>\r\n            ");
#nullable restore
#line 77 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       Write(Html.TextBoxFor(model => model.Papel, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!--<input type=""number"" name=""Peso"" id=""aluminio"">-->
          </div>
        </div>

        <div class=""card"">
          <img src=""assets/img/vidro.jpg"" class=""card-img-top "" alt=""caixa com vidro"">
          <div class=""card-body"">
            <h5 class=""card-title text-dark"">vidro</h5>
            <select>
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c55337a1b420a07b5f157ead19ae801d8d28dd6e12762", async() => {
                WriteLiteral("\r\n                Vidro\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n            <span>Insira o peso em Kg</span>\r\n            ");
#nullable restore
#line 92 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
       Write(Html.TextBoxFor(model => model.Vidro, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--<input type=\"number\" name=\"Peso\" id=\"aluminio\">-->\r\n          </div>\r\n        </div>\r\n\r\n      </section>\r\n      <!--</form>-->\r\n");
#nullable restore
#line 99 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <!--<div class=\"form-group\">\r\n                            <span>tipo:</span>\r\n    ");
#nullable restore
#line 105 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
Write(Html.TextBoxFor(model => model.TipMat, new {@type= "number", @class="form-control", @min = "0"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                          </div>\r\n                        <div class=\"form-group\">\r\n                            <span>Peso:</span>\r\n    ");
#nullable restore
#line 110 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
Write(Html.TextBoxFor(model => model.Pes, new {@type= "number", @class="form-control", @min = "0"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                  </div>\r\n                    </div>\r\n                </div>\r\n                      <div class=\"form-group\">\r\n                            <span>tipo:</span>\r\n    ");
#nullable restore
#line 118 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
Write(Html.TextBoxFor(model => model.TipMat , new {@type= "number", @class="form-control", @min = "0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                          </div>\r\n                      <div class=\"form-group\">\r\n                              <span>Peso:</span>\r\n    ");
#nullable restore
#line 123 "D:\TCC\ReciGanhaMVC\Views\Shared\NewColeta.cshtml"
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
