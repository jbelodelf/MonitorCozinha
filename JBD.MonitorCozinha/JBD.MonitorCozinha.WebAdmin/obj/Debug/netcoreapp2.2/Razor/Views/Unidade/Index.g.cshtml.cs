#pragma checksum "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bac932e1d17f56feb5018019f8401074c615b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Unidade_Index), @"mvc.1.0.view", @"/Views/Unidade/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Unidade/Index.cshtml", typeof(AspNetCore.Views_Unidade_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bac932e1d17f56feb5018019f8401074c615b3d", @"/Views/Unidade/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060aecd92d5438e5f236708e2a1d922fed2c393a", @"/Views/_ViewImports.cshtml")]
    public class Views_Unidade_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JBD.MonitorCozinha.WebAdmin.Models.UnidadeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 246, true);
            WriteLiteral("    \r\n<div id=\"mensagem\" name=\"mensagem\" style=\"display: none; background-color: #ff2d296b; text-align:center; height: 40px; padding-top: 5px; font-size: 20px;\"><b>mensagem</b></div>\r\n<div class=\"align-content-center\" style=\"text-align:center\">\r\n");
            EndContext();
            BeginContext(359, 39, true);
            WriteLiteral("    <input type=\"hidden\" id=\"IdEmpresa\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 398, "\"", 422, 1);
#line 6 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
WriteAttributeValue("", 406, Model.IdEmpresa, 406, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(423, 44, true);
            WriteLiteral(" />\r\n\r\n    <h3 class=\"modal-title\">Empresa: ");
            EndContext();
            BeginContext(468, 17, false);
#line 8 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                                Write(Model.NomeEmpresa);

#line default
#line hidden
            EndContext();
            BeginContext(485, 359, true);
            WriteLiteral(@"</h3>
</div>
<div class=""col-md-8 form-inline"" style="""">
    <div class=""col-md-1"" style=""padding-right: 80px"">
        <button class=""btn btn-primary"" id=""btVoltar"">Voltar</button>
    </div>
    <div class=""col-md-1"">
        <button class=""btn btn-primary"" id=""btNovo"">Cadastrar</button>
    </div>
</div>

<div id=""divListarUnidades""></div>

");
            EndContext();
            BeginContext(903, 1029, true);
            WriteLiteral(@"
<!-- Modal para cadastrar cliente -->
<div class=""modal fade"" id=""ModalCadastrarUnidade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""fatorFModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
    <div class=""modal-dialog border-dark"">
        <div class=""modal-content"" style=""width: 200%; margin-left: -50%;"">
            <!-- Modal Header -->
            <div id=""mensagemModal"" name=""mensagem"" style=""display: none; background-color: #ff2d296b; text-align:center; height: 40px; padding-top: 5px; font-size: 20px;""><b>mensagem</b></div>

            <div class=""modal-header"">
                <div class=""col-md-11"">
                    <h3 class=""modal-title"">Cadastrar Unidade</h3>
                </div>
                <div class=""col-md-1"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
            </div>
            <!-- Modal body -->
            <!---------------------------------------------------");
            WriteLiteral(">\r\n\r\n");
            EndContext();
#line 41 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
             using (Html.BeginForm("Salvar", "Unidade", FormMethod.Post, new { name = "frmCliente", id = "frmCliente" }))
            {
                

#line default
#line hidden
            BeginContext(2087, 23, false);
#line 43 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2112, 65, true);
            WriteLiteral("                <input type=\"hidden\" id=\"IdUnidade\" value=\"\" />\r\n");
            EndContext();
            BeginContext(2197, 56, true);
            WriteLiteral("                <fieldset>\r\n                    <legend>");
            EndContext();
            BeginContext(2254, 13, false);
#line 48 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                       Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2267, 86, true);
            WriteLiteral("</legend>\r\n                    <div class=\"form-horizontal\">\r\n                        ");
            EndContext();
            BeginContext(2354, 64, false);
#line 50 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2418, 163, true);
            WriteLiteral("\r\n\r\n                        <div class=\"form-group row col-md-12\">\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(2582, 93, false);
#line 54 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-8" }));

#line default
#line hidden
            EndContext();
            BeginContext(2675, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(2771, 112, false);
#line 56 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2883, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2922, 82, false);
#line 57 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3004, 175, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(3180, 92, false);
#line 62 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.CEP, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(3272, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(3368, 119, false);
#line 64 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.CEP, new { htmlAttributes = new { @class = "form-control cepClass", @maxlength = "9" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3487, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3526, 81, false);
#line 65 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.CEP, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3607, 273, true);
            WriteLiteral(@"
                                </div>
                            </div>

                        </div>

                        <div class=""form-group row col-md-12"">
                            <div class=""form-group col-md-4"">
                                ");
            EndContext();
            BeginContext(3881, 97, false);
#line 73 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Endereco, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(3978, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(4074, 116, false);
#line 75 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Endereco, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4190, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4229, 86, false);
#line 76 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Endereco, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4315, 175, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(4491, 95, false);
#line 81 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Bairro, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4586, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(4682, 114, false);
#line 83 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Bairro, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4796, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4835, 84, false);
#line 84 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Bairro, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4919, 173, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(5093, 95, false);
#line 88 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Cidade, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5188, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(5284, 114, false);
#line 90 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Cidade, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5398, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(5437, 84, false);
#line 91 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Cidade, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5521, 279, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            
                            <div class=""form-group row col-md-12"">
                                <div class=""form-group col-md-2"">
                                    ");
            EndContext();
            BeginContext(5801, 95, false);
#line 97 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.LabelFor(model => model.Estado, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5896, 103, true);
            WriteLiteral("\r\n                                    <div class=\"col-md-12\">\r\n                                        ");
            EndContext();
            BeginContext(6000, 114, false);
#line 99 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                                   Write(Html.EditorFor(model => model.Estado, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6114, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(6157, 84, false);
#line 100 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Estado, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6241, 240, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"form-group col-md-6\">\r\n                                    <label>\r\n                                        ");
            EndContext();
            BeginContext(6482, 93, false);
#line 106 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                                   Write(Html.LabelFor(model => model.Pais, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(6575, 333, true);
            WriteLiteral(@"
                                        <div class=""col-md-12"">
                                            <select id=""Pais"" class=""form-control""></select>
                                        </div>
                                    </label>
                                </div>
                            </div>

");
            EndContext();
            BeginContext(7416, 70, true);
            WriteLiteral("                                <input type=\"hidden\" id=\"DataCadastro\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7486, "\"", 7507, 1);
#line 121 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
WriteAttributeValue("", 7494, DateTime.Now, 7494, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7508, 155, true);
            WriteLiteral(" />\r\n                                <input type=\"hidden\" id=\"IdStatus\" value=\"\" />\r\n                                <input type=\"hidden\" id=\"idEmpresaNum\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7663, "\"", 7687, 1);
#line 123 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
WriteAttributeValue("", 7671, Model.IdEmpresa, 7671, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7688, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(7775, 101, true);
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                </fieldset>\r\n");
            EndContext();
#line 130 "F:\Projetos_Gerais\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(7891, 557, true);
            WriteLiteral(@"
            <!--------------------------------------------------->
            <!-- Modal footer -->
            <div class=""modal-footer"">
                <div class=""col-md-12"">
                    <button id=""btnFecharUnidade"" type=""button"" class=""btn btn-danger"">&nbsp;&nbsp;&nbsp;Fechar&nbsp;&nbsp;&nbsp;</button>
                    <button id=""btnSalvarUnidade"" type=""button"" class=""btn btn-outline-success"">&nbsp;&nbsp;&nbsp;Salvar&nbsp;&nbsp;&nbsp;</button>

                </div>
            </div>

        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JBD.MonitorCozinha.WebAdmin.Models.UnidadeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
