#pragma checksum "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8b75cfea25e692a7eb51467b849515911353c5e"
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
#line 1 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\_ViewImports.cshtml"
using JBD.MonitorCozinha.WebAdmin;

#line default
#line hidden
#line 2 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\_ViewImports.cshtml"
using JBD.MonitorCozinha.WebAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8b75cfea25e692a7eb51467b849515911353c5e", @"/Views/Unidade/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060aecd92d5438e5f236708e2a1d922fed2c393a", @"/Views/_ViewImports.cshtml")]
    public class Views_Unidade_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JBD.MonitorCozinha.WebAdmin.Models.UnidadeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Views/Unidade/Unidade.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 817, true);
            WriteLiteral(@"
    
<div id=""mensagem"" name=""mensagem"" style=""display: none; background-color: #ff2d296b; text-align:center; height: 40px; padding-top: 5px; font-size: 20px;""><b>mensagem</b></div>
<div class=""jumbotron row topJumboTrom"" id=""TopoPesquisa"">
    <div class=""col-md-8 form-group row"">
        <div class=""col-md-4"">
            <lable>Nome unidade</lable>
        </div>
        <div class=""col-md-8"">
            <input type=""text"" class=""form-control"" id=""UnidadePesquisar"" name=""UnidadePesquisar"" />
        </div>
    </div>
    <div class=""col-md-1"">
        <button class=""btn btn-primary"" id=""btPesquisar"">Pesquisar</button>
    </div>
    <div class=""col-md-1"">
        <button class=""btn btn-primary"" id=""btNovo"">Cadastrar</button>
    </div>
</div>

<div id=""divListarUnidades""></div>

");
            EndContext();
            BeginContext(877, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8b75cfea25e692a7eb51467b849515911353c5e5057", async() => {
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
            BeginContext(930, 1031, true);
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
            <!-------------------------------------------------");
            WriteLiteral("-->\r\n\r\n");
            EndContext();
#line 44 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
             using (Html.BeginForm("Salvar", "Unidade", FormMethod.Post, new { name = "frmCliente", id = "frmCliente" }))
            {
                

#line default
#line hidden
            BeginContext(2116, 23, false);
#line 46 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2141, 65, true);
            WriteLiteral("                <input type=\"hidden\" id=\"IdUnidade\" value=\"\" />\r\n");
            EndContext();
            BeginContext(2208, 56, true);
            WriteLiteral("                <fieldset>\r\n                    <legend>");
            EndContext();
            BeginContext(2265, 13, false);
#line 50 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                       Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2278, 86, true);
            WriteLiteral("</legend>\r\n                    <div class=\"form-horizontal\">\r\n                        ");
            EndContext();
            BeginContext(2365, 64, false);
#line 52 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 231, true);
            WriteLiteral("\r\n\r\n                        <div class=\"form-group row col-md-12\">\r\n                            <div class=\"form-group col-md-3\">\r\n                                <label for=\"cargo\">Empresa</label>\r\n                                ");
            EndContext();
            BeginContext(2660, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8b75cfea25e692a7eb51467b849515911353c5e9347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 57 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdEmpresa);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 57 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@Model.Empresas, "IdEmpresa", "NomeFantasia"));

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2794, 133, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(2928, 93, false);
#line 60 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-8" }));

#line default
#line hidden
            EndContext();
            BeginContext(3021, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(3117, 112, false);
#line 62 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3229, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3268, 82, false);
#line 63 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3350, 175, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(3526, 92, false);
#line 68 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.CEP, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(3618, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(3714, 111, false);
#line 70 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.CEP, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3825, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3864, 81, false);
#line 71 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.CEP, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3945, 273, true);
            WriteLiteral(@"
                                </div>
                            </div>

                        </div>

                        <div class=""form-group row col-md-12"">
                            <div class=""form-group col-md-4"">
                                ");
            EndContext();
            BeginContext(4219, 97, false);
#line 79 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Endereco, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(4316, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(4412, 116, false);
#line 81 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Endereco, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4528, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4567, 86, false);
#line 82 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Endereco, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4653, 175, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(4829, 95, false);
#line 87 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Bairro, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4924, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(5020, 114, false);
#line 89 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Bairro, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5134, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(5173, 84, false);
#line 90 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Bairro, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5257, 173, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group col-md-4\">\r\n                                ");
            EndContext();
            BeginContext(5431, 95, false);
#line 94 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Cidade, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5526, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(5622, 114, false);
#line 96 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Cidade, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5736, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(5775, 84, false);
#line 97 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Cidade, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5859, 173, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group col-md-2\">\r\n                                ");
            EndContext();
            BeginContext(6033, 95, false);
#line 101 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Estado, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(6128, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(6224, 114, false);
#line 103 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Estado, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6338, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6377, 84, false);
#line 104 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Estado, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6461, 173, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group col-md-2\">\r\n                                ");
            EndContext();
            BeginContext(6635, 93, false);
#line 108 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                           Write(Html.LabelFor(model => model.Pais, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(6728, 95, true);
            WriteLiteral("\r\n                                <div class=\"col-md-12\">\r\n                                    ");
            EndContext();
            BeginContext(6824, 112, false);
#line 110 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.EditorFor(model => model.Pais, new { htmlAttributes = new { @class = "form-control", @maxlength = "60" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6936, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6975, 82, false);
#line 111 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Pais, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7057, 144, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <input type=\"hidden\" id=\"DataCadastro\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7201, "\"", 7222, 1);
#line 114 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
WriteAttributeValue("", 7209, DateTime.Now, 7209, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7223, 170, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" id=\"IdStatus\" value=\"\" />\r\n                        </div>\r\n                    </div>\r\n                </fieldset>\r\n");
            EndContext();
#line 119 "D:\Projetos\MonitorCozinha\JBD.MonitorCozinha\JBD.MonitorCozinha.WebAdmin\Views\Unidade\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(7408, 557, true);
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
