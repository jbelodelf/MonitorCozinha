#pragma checksum "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\MainMonitor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b19eec884b9c814df171d430ffefc01f47e9b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MonitorAdmin_MainMonitor), @"mvc.1.0.view", @"/Views/MonitorAdmin/MainMonitor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MonitorAdmin/MainMonitor.cshtml", typeof(AspNetCore.Views_MonitorAdmin_MainMonitor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b19eec884b9c814df171d430ffefc01f47e9b1", @"/Views/MonitorAdmin/MainMonitor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060aecd92d5438e5f236708e2a1d922fed2c393a", @"/Views/_ViewImports.cshtml")]
    public class Views_MonitorAdmin_MainMonitor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JBD.MonitorCozinha.WebAdmin.Models.NumeroPedidoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 162, true);
            WriteLiteral("\r\n<table class=\"table table-bordered\" style=\"border: 5px solid #dee2e6 !important;\" id=\"divTop\">\r\n    <tbody>\r\n        <tr id=\"divFazer\" style=\"height: 550px;\">\r\n");
            EndContext();
            BeginContext(406, 105, true);
            WriteLiteral("            <td id=\"tdFazendo\" style=\"width:33%;border: 5px solid #dee2e6 !important;\">\r\n                ");
            EndContext();
            BeginContext(512, 38, false);
#line 10 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\MainMonitor.cshtml"
           Write(Html.Partial("_MonitorFazendo", Model));

#line default
#line hidden
            EndContext();
            BeginContext(550, 125, true);
            WriteLiteral("\r\n            </td>\r\n            <td id=\"tdPronto\" style=\"width:33%;border: 5px solid #dee2e6 !important;\">\r\n                ");
            EndContext();
            BeginContext(676, 37, false);
#line 13 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\MonitorAdmin\MainMonitor.cshtml"
           Write(Html.Partial("_MonitorPronto", Model));

#line default
#line hidden
            EndContext();
            BeginContext(713, 60, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
