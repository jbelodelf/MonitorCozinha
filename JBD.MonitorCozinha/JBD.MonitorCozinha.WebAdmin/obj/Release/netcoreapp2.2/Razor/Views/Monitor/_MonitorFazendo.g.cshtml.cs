#pragma checksum "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitorFazendo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "258b3fa794576b5fa5fc8ee1d31e4453a2590456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monitor__MonitorFazendo), @"mvc.1.0.view", @"/Views/Monitor/_MonitorFazendo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Monitor/_MonitorFazendo.cshtml", typeof(AspNetCore.Views_Monitor__MonitorFazendo))]
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
#line 1 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitorFazendo.cshtml"
using JBD.MonitorCozinha.Domain.Enuns;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"258b3fa794576b5fa5fc8ee1d31e4453a2590456", @"/Views/Monitor/_MonitorFazendo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060aecd92d5438e5f236708e2a1d922fed2c393a", @"/Views/_ViewImports.cshtml")]
    public class Views_Monitor__MonitorFazendo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JBD.MonitorCozinha.WebAdmin.Models.NumeroPedidoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(119, 43, true);
            WriteLiteral("\r\n<div class=\"table col-lg-12 col-sm-12\">\r\n");
            EndContext();
#line 5 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitorFazendo.cshtml"
     foreach (var item in Model)
    {
        if (item.IdStatusPedido == StatusPedidoEnum.Fazendo)
        {

#line default
#line hidden
            BeginContext(276, 105, true);
            WriteLiteral("            <div class=\"float-left p-2\"><span id=\"b\"><button class=\"btn btn-outline-primary form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 381, "\"", 409, 1);
#line 9 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitorFazendo.cshtml"
WriteAttributeValue("", 389, item.IdStatusPedido, 389, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(410, 27, true);
            WriteLiteral(" style=\"font-size:50px\"><b>");
            EndContext();
            BeginContext(438, 17, false);
#line 9 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitorFazendo.cshtml"
                                                                                                                                                            Write(item.NumeroPedido);

#line default
#line hidden
            EndContext();
            BeginContext(455, 28, true);
            WriteLiteral("</b></button></span></div>\r\n");
            EndContext();
#line 10 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitorFazendo.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(501, 8, true);
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
