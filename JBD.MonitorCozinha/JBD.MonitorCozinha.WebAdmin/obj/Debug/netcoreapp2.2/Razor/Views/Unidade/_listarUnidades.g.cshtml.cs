#pragma checksum "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f15880877d8cfad3a972605cc4b8de7046071f9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Unidade__listarUnidades), @"mvc.1.0.view", @"/Views/Unidade/_listarUnidades.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Unidade/_listarUnidades.cshtml", typeof(AspNetCore.Views_Unidade__listarUnidades))]
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
#line 1 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\_ViewImports.cshtml"
using JBD.MonitorCozinha.WebAdmin;

#line default
#line hidden
#line 2 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\_ViewImports.cshtml"
using JBD.MonitorCozinha.WebAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f15880877d8cfad3a972605cc4b8de7046071f9d", @"/Views/Unidade/_listarUnidades.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060aecd92d5438e5f236708e2a1d922fed2c393a", @"/Views/_ViewImports.cshtml")]
    public class Views_Unidade__listarUnidades : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JBD.MonitorCozinha.WebAdmin.Models.EmpresaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fontawesome/fontawesome-free-5.9.0-web/js/all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 115, true);
            WriteLiteral("\r\n<table class=\"table table-striped table-bordered table-hover\" id=\"tbListarUnidades\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(420, 18, true);
            WriteLiteral("            <th>\r\n");
            EndContext();
            BeginContext(510, 67, true);
            WriteLiteral("                Nome Unidade\r\n            </th>\r\n            <th>\r\n");
            EndContext();
            BeginContext(640, 58, true);
            WriteLiteral("                CEP\r\n            </th>\r\n            <th>\r\n");
            EndContext();
            BeginContext(765, 63, true);
            WriteLiteral("                Endereço\r\n            </th>\r\n            <th>\r\n");
            EndContext();
            BeginContext(893, 61, true);
            WriteLiteral("                Bairro\r\n            </th>\r\n            <th>\r\n");
            EndContext();
            BeginContext(1019, 61, true);
            WriteLiteral("                Cidade\r\n            </th>\r\n            <th>\r\n");
            EndContext();
            BeginContext(1145, 61, true);
            WriteLiteral("                Estado\r\n            </th>\r\n            <th>\r\n");
            EndContext();
            BeginContext(1269, 41, true);
            WriteLiteral("                Pais\r\n            </th>\r\n");
            EndContext();
            BeginContext(1577, 65, true);
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 53 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
         foreach (var item in Model.Unidades)
        {

#line default
#line hidden
            BeginContext(1700, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
            BeginContext(1961, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(2004, 39, false);
#line 63 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2111, 38, false);
#line 66 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2217, 43, false);
#line 69 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(2260, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2328, 41, false);
#line 72 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(2369, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2437, 41, false);
#line 75 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(2478, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2546, 41, false);
#line 78 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2587, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2655, 39, false);
#line 81 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(2694, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(2949, 64, true);
            WriteLiteral("                <td>\r\n                    <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3013, "\"", 3054, 3);
            WriteAttributeValue("", 3023, "Unidade.Editar(", 3023, 15, true);
#line 90 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
WriteAttributeValue("", 3038, item.IdUnidade, 3038, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3053, ")", 3053, 1, true);
            EndWriteAttribute();
            BeginContext(3055, 91, true);
            WriteLiteral(" title=\"Editar\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3146, "\"", 3188, 3);
            WriteAttributeValue("", 3156, "Unidade.Excluir(", 3156, 16, true);
#line 91 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
WriteAttributeValue("", 3172, item.IdUnidade, 3172, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3187, ")", 3187, 1, true);
            EndWriteAttribute();
            BeginContext(3189, 53, true);
            WriteLiteral(" title=\"Excluir\"><i class=\"fas fa-trash\"></i></a>\r\n\r\n");
            EndContext();
            BeginContext(3532, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 98 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
        }

#line default
#line hidden
            BeginContext(3585, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(3609, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f15880877d8cfad3a972605cc4b8de7046071f9d11098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JBD.MonitorCozinha.WebAdmin.Models.EmpresaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
