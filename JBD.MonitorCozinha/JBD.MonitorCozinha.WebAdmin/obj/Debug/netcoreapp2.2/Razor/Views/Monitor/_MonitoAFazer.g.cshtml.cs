#pragma checksum "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitoAFazer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6b762a6a1d9c6f3966c1d90a791562e40211b32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monitor__MonitoAFazer), @"mvc.1.0.view", @"/Views/Monitor/_MonitoAFazer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Monitor/_MonitoAFazer.cshtml", typeof(AspNetCore.Views_Monitor__MonitoAFazer))]
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
#line 1 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitoAFazer.cshtml"
using JBD.MonitorCozinha.Domain.Enuns;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6b762a6a1d9c6f3966c1d90a791562e40211b32", @"/Views/Monitor/_MonitoAFazer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060aecd92d5438e5f236708e2a1d922fed2c393a", @"/Views/_ViewImports.cshtml")]
    public class Views_Monitor__MonitoAFazer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JBD.MonitorCozinha.WebAdmin.Models.NumeroPedidoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(119, 43, true);
            WriteLiteral("\r\n<div class=\"table col-lg-12 col-sm-12\">\r\n");
            EndContext();
#line 5 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitoAFazer.cshtml"
     foreach (var item in Model)
    {
        if (item.IdStatusPedido == StatusPedidoEnum.AFazer)
        {

#line default
#line hidden
            BeginContext(275, 102, true);
            WriteLiteral("            <div class=\"float-left p-2\"><span id=\"b\"><button class=\"btn btn-outline-dark form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 377, "\"", 405, 1);
#line 9 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitoAFazer.cshtml"
WriteAttributeValue("", 385, item.IdStatusPedido, 385, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(406, 27, true);
            WriteLiteral(" style=\"font-size:40px\"><b>");
            EndContext();
            BeginContext(434, 17, false);
#line 9 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitoAFazer.cshtml"
                                                                                                                                                         Write(item.NumeroPedido);

#line default
#line hidden
            EndContext();
            BeginContext(451, 28, true);
            WriteLiteral("</b></button></span></div>\r\n");
            EndContext();
#line 10 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Monitor\_MonitoAFazer.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(497, 8, true);
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
