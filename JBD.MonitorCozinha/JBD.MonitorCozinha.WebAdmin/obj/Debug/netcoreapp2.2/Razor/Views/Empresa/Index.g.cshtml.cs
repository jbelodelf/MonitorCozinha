#pragma checksum "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aaedf88ea60282e1911020d5679c69904be7846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Index), @"mvc.1.0.view", @"/Views/Empresa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empresa/Index.cshtml", typeof(AspNetCore.Views_Empresa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aaedf88ea60282e1911020d5679c69904be7846", @"/Views/Empresa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060aecd92d5438e5f236708e2a1d922fed2c393a", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JBD.MonitorCozinha.WebAdmin.Models.EmpresaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 113, true);
            WriteLiteral("    <style type=\"text/css\">\r\n        label {\r\n            text-align: left !important;\r\n        }\r\n    </style>\r\n");
            EndContext();
            BeginContext(182, 725, true);
            WriteLiteral(@"

<div id=""mensagem"" name=""mensagem"" style=""display: none; background-color: #ff2d296b; text-align:center; height: 40px; padding-top: 5px; font-size: 20px;""><b>mensagem</b></div>
<div class=""jumbotron row topJumboTrom"" id=""TopoPesquisa"">
    <div class=""col-md-12 form-group row"">
        <div class=""col-md-2"" style=""text-align:right ; padding-top: 5px;"">
            <lable style=""font-size:18px ;"">Nome Fantasia</lable>
        </div>
        <div class=""col-md-5"">
            <input type=""text"" class=""form-control"" id=""EmpresaPesquisar"" name=""EmpresaPesquisar"" />
        </div>
        <div class=""col-md-1"">
            <button class=""btn btn-primary"" id=""btPesquisar"">Pesquisar</button>
        </div>
");
            EndContext();
            BeginContext(1046, 184, true);
            WriteLiteral("        <div class=\"col-md-1\">\r\n            <button class=\"btn btn-primary\" id=\"btNovo\">Cadastrar</button>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<div id=\"divListarEmpresas\"></div>\r\n\r\n");
            EndContext();
            BeginContext(1289, 1029, true);
            WriteLiteral(@"
<!-- Modal para cadastrar cliente -->
<div class=""modal fade"" id=""ModalCadastrarEmpresa"" tabindex=""-1"" role=""dialog"" aria-labelledby=""fatorFModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
    <div class=""modal-dialog border-dark"">
        <div class=""modal-content"" style=""width: 200%; margin-left: -50%;"">
            <!-- Modal Header -->
            <div id=""mensagemModal"" name=""mensagem"" style=""display: none; background-color: #ff2d296b; text-align:center; height: 40px; padding-top: 5px; font-size: 20px;""><b>mensagem</b></div>

            <div class=""modal-header"">
                <div class=""col-md-11"">
                    <h3 class=""modal-title"">Cadastrar Empresa</h3>
                </div>
                <div class=""col-md-1"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
            </div>
            <!-- Modal body -->
            <!---------------------------------------------------");
            WriteLiteral(">\r\n\r\n");
            EndContext();
#line 55 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
             using (Html.BeginForm("Salvar", "Empresa", FormMethod.Post, new { name = "frmCliente", id = "frmCliente" }))
            {
                

#line default
#line hidden
            BeginContext(2473, 23, false);
#line 57 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2498, 65, true);
            WriteLiteral("                <input type=\"hidden\" id=\"IdEmpresa\" value=\"\" />\r\n");
            EndContext();
            BeginContext(2565, 56, true);
            WriteLiteral("                <fieldset>\r\n                    <legend>");
            EndContext();
            BeginContext(2622, 13, false);
#line 61 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                       Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2635, 86, true);
            WriteLiteral("</legend>\r\n                    <div class=\"form-horizontal\">\r\n                        ");
            EndContext();
            BeginContext(2722, 64, false);
#line 63 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2786, 163, true);
            WriteLiteral("\r\n\r\n                        <div class=\"form-group row col-md-12\">\r\n                            <div class=\"form-group col-md-3\">\r\n                                ");
            EndContext();
            BeginContext(2950, 93, false);
#line 67 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                           Write(Html.LabelFor(model => model.CNPJ, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3043, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(3139, 138, false);
#line 69 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.EditorFor(model => model.CNPJ, new { htmlAttributes = new { @class = "form-control", @maxlength = "14", @autofocus = "autofocus" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3277, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3316, 82, false);
#line 70 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.CNPJ, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3398, 173, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group col-md-6\">\r\n                                ");
            EndContext();
            BeginContext(3572, 100, false);
#line 74 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                           Write(Html.LabelFor(model => model.RazaoSocial, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
            EndContext();
            BeginContext(3672, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(3768, 119, false);
#line 76 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.EditorFor(model => model.RazaoSocial, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3887, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3926, 89, false);
#line 77 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.RazaoSocial, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4015, 271, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>

                        <div class=""form-group row col-md-12"">
                            <div class=""form-group col-md-6"">
                                ");
            EndContext();
            BeginContext(4287, 101, false);
#line 84 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                           Write(Html.LabelFor(model => model.NomeFantasia, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
            EndContext();
            BeginContext(4388, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(4484, 120, false);
#line 86 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.EditorFor(model => model.NomeFantasia, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4604, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4643, 90, false);
#line 87 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.NomeFantasia, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4733, 175, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(4909, 106, false);
#line 92 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                           Write(Html.LabelFor(model => model.InscricaoEstadual, htmlAttributes: new { @class = "control-label col-md-8" }));

#line default
#line hidden
            EndContext();
            BeginContext(5015, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(5111, 125, false);
#line 94 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.EditorFor(model => model.InscricaoEstadual, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5236, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(5275, 95, false);
#line 95 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.InscricaoEstadual, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5370, 173, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(5544, 107, false);
#line 99 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                           Write(Html.LabelFor(model => model.InscricaoMunicipal, htmlAttributes: new { @class = "control-label col-md-8" }));

#line default
#line hidden
            EndContext();
            BeginContext(5651, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(5747, 126, false);
#line 101 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.EditorFor(model => model.InscricaoMunicipal, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5873, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(5912, 96, false);
#line 102 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.InscricaoMunicipal, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6008, 144, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <input type=\"hidden\" id=\"DataCadastro\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6152, "\"", 6173, 1);
#line 105 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
WriteAttributeValue("", 6160, DateTime.Now, 6160, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6174, 170, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" id=\"IdStatus\" value=\"\" />\r\n                        </div>\r\n                    </div>\r\n                </fieldset>\r\n");
            EndContext();
#line 110 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Empresa\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(6359, 612, true);
            WriteLiteral(@"
            <!--------------------------------------------------->
            <!-- Modal footer -->
            <div class=""modal-footer"" style=""display:grid"">
                <div class=""col-md-12"" style=""align-content: flex-end"">
                    <button id=""btnFecharEmpresa"" type=""button"" class=""btn btn-danger"">&nbsp;&nbsp;&nbsp;Fechar&nbsp;&nbsp;&nbsp;</button>
                    <button id=""btnSalvarEmpresa"" type=""button"" class=""btn btn-outline-success"">&nbsp;&nbsp;&nbsp;Salvar&nbsp;&nbsp;&nbsp;</button>

                </div>
            </div>

        </div>
    </div>
</div>
");
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
