#pragma checksum "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142270858e34cc93cd05940466525de9cb1ad503"
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
#line 1 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\_ViewImports.cshtml"
using JBD.MonitorCozinha.WebAdmin;

#line default
#line hidden
#line 2 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\_ViewImports.cshtml"
using JBD.MonitorCozinha.WebAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142270858e34cc93cd05940466525de9cb1ad503", @"/Views/Unidade/_listarUnidades.cshtml")]
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
            BeginContext(60, 631, true);
            WriteLiteral(@"
<table class=""table table-striped table-bordered table-hover"" id=""tbListarUnidades"">
    <thead>
        <tr>
            <th>
                Nome Unidade
            </th>
            <th>
                CEP
            </th>
            <th>
                Endereço
            </th>
            <th>
                Bairro
            </th>
            <th>
                Cidade
            </th>
            <th>
                Estado
            </th>
            <th>
                Pais
            </th>
            <th style=""width:150px;""></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 31 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
         foreach (var item in Model.Unidades)
        {

#line default
#line hidden
            BeginContext(749, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(810, 39, false);
#line 35 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(849, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(917, 38, false);
#line 38 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(955, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1023, 43, false);
#line 41 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1134, 41, false);
#line 44 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1243, 41, false);
#line 47 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1352, 41, false);
#line 50 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1461, 39, false);
#line 53 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1589, "\"", 1630, 3);
            WriteAttributeValue("", 1599, "Unidade.Editar(", 1599, 15, true);
#line 56 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
WriteAttributeValue("", 1614, item.IdUnidade, 1614, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1629, ")", 1629, 1, true);
            EndWriteAttribute();
            BeginContext(1631, 99, true);
            WriteLiteral(" title=\"Editar unidade\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1730, "\"", 1772, 3);
            WriteAttributeValue("", 1740, "Unidade.Excluir(", 1740, 16, true);
#line 57 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
WriteAttributeValue("", 1756, item.IdUnidade, 1756, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1771, ")", 1771, 1, true);
            EndWriteAttribute();
            BeginContext(1773, 173, true);
            WriteLiteral(" title=\"Excluir unidade\"><i class=\"fas fa-trash\"></i></a>\r\n                    <span style=\"font-size:25px;\">&nbsp;|&nbsp;</span>\r\n                    <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1946, "\"", 1993, 3);
            WriteAttributeValue("", 1956, "Unidade.ListarPessoa(", 1956, 21, true);
#line 59 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
WriteAttributeValue("", 1977, item.IdUnidade, 1977, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1992, ")", 1992, 1, true);
            EndWriteAttribute();
            BeginContext(1994, 107, true);
            WriteLiteral(" title=\"Lista de usuários\"><i class=\'fas fa-user-plus\'></i></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 62 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\_listarUnidades.cshtml"
        }

#line default
#line hidden
            BeginContext(2112, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(2136, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142270858e34cc93cd05940466525de9cb1ad50310543", async() => {
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
