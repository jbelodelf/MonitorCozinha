#pragma checksum "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db4293a84de8ed6444e53659783e7ba0c1fdd11b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MonitorAdmin__MonitorPronto), @"mvc.1.0.view", @"/Views/MonitorAdmin/_MonitorPronto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MonitorAdmin/_MonitorPronto.cshtml", typeof(AspNetCore.Views_MonitorAdmin__MonitorPronto))]
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
#line 1 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
using JBD.MonitorCozinha.Domain.Enuns;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db4293a84de8ed6444e53659783e7ba0c1fdd11b", @"/Views/MonitorAdmin/_MonitorPronto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060aecd92d5438e5f236708e2a1d922fed2c393a", @"/Views/_ViewImports.cshtml")]
    public class Views_MonitorAdmin__MonitorPronto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JBD.MonitorCozinha.WebAdmin.Models.NumeroPedidoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(119, 43, true);
            WriteLiteral("\r\n<div class=\"table col-lg-12 col-sm-12\">\r\n");
            EndContext();
#line 5 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
     foreach (var item in Model)
    {
        if (item.IdStatusPedido == StatusPedidoEnum.Pronto)
        {

#line default
#line hidden
            BeginContext(275, 145, true);
            WriteLiteral("            <div class=\"float-left p-2\">\r\n                <span id=\"b\">\r\n                    <button class=\"btn btn-outline-success form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 420, "\"", 448, 1);
#line 11 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
WriteAttributeValue("", 428, item.IdStatusPedido, 428, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(449, 26, true);
            WriteLiteral(" style=\"font-size:40px\">\r\n");
            EndContext();
#line 12 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
                         if (Controle.ControleAcesso.IdTipo != TipoUsuarioEnum.Operacional)
                        {

#line default
#line hidden
            BeginContext(595, 54, true);
            WriteLiteral("                            <a href=\"#\" id=\"btFazendo\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 649, "\"", 712, 4);
            WriteAttributeValue("", 659, "MonitorAdmin.AtualizarStatus(", 659, 29, true);
#line 14 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
WriteAttributeValue("", 688, item.IdNumeroPedido, 688, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 708, ",", 708, 1, true);
            WriteAttributeValue(" ", 709, "2)", 710, 3, true);
            EndWriteAttribute();
            BeginContext(713, 150, true);
            WriteLiteral(" title=\"Voltar para Fazendo\">\r\n                                <i class=\"fa fa-arrow-left\" aria-hidden=\"true\"></i>\r\n                            </a>\r\n");
            EndContext();
#line 17 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
                        }

#line default
#line hidden
            BeginContext(890, 27, true);
            WriteLiteral("                        <b>");
            EndContext();
            BeginContext(918, 17, false);
#line 18 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
                      Write(item.NumeroPedido);

#line default
#line hidden
            EndContext();
            BeginContext(935, 6, true);
            WriteLiteral("</b>\r\n");
            EndContext();
#line 19 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
                         if (Controle.ControleAcesso.IdTipo != TipoUsuarioEnum.Operacional)
                        {

#line default
#line hidden
            BeginContext(1061, 55, true);
            WriteLiteral("                            <a href=\"#\" id=\"btEntregue\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1116, "\"", 1179, 4);
            WriteAttributeValue("", 1126, "MonitorAdmin.AtualizarStatus(", 1126, 29, true);
#line 21 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
WriteAttributeValue("", 1155, item.IdNumeroPedido, 1155, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1175, ",", 1175, 1, true);
            WriteAttributeValue(" ", 1176, "4)", 1177, 3, true);
            EndWriteAttribute();
            BeginContext(1180, 158, true);
            WriteLiteral(" title=\"Mudar para pedido retirado\">\r\n                                <i class=\"fa fa-arrow-right\" aria-hidden=\"true\"></i>\r\n                            </a>\r\n");
            EndContext();
#line 24 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
                        }

#line default
#line hidden
            BeginContext(1365, 76, true);
            WriteLiteral("                    </button>\r\n                </span>\r\n            </div>\r\n");
            EndContext();
#line 28 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\_MonitorPronto.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1459, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JBD.MonitorCozinha.WebAdmin.Models.NumeroPedidoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591