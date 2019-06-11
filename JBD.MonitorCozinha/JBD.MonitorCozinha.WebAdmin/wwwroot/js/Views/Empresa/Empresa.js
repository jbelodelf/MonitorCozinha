var Empresa = {
    Listar: function () {
        $("body").css("padding-top", "2px", "!important");
        $("#TopoPesquisa").css("margin-left", "5px");
        $("#TopoPesquisa").css("margin-right", "5px");
        $("#TopoPesquisa").css("padding-top", "20px");
        $("#TopoPesquisa").css("padding-bottom", "15px");
        var empresa = $("#EmpresaPesquisar").val();

        var url = "/Empresa/ListarEmpresas";
        $.ajax({
            url: url
            , datatype: "json"
            , type: "GET"
            , async: false
            , data: { nomeEmpresa: empresa }
            , cache: false
        }).done(function (data) {
            $("#divListarEmpresas").html(data);

            $("#cabecalho").css("background-color", "#5B9BD5")
            $("#cabecalho").css("color", "#FFFFFF")
            $("#colNome").css("width", "480");
            AplicarDataTable('tbListarEmpresas', '0', "asc", 20, false, undefined, true);
            //$("#tbListarEmpresas").css("margin-top", "-50px");
            //$("#tbListarEmpresas").css("float", "right");
            //$("#footer").css("margin-top", "50px");
            //$("#footer").css("height", "40px");
            //$("#footer").css("padding", "10px");
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    },
}

$(document).ready(function () {
    var url = window.location.pathname;
    if ((url == "/") || (url == "/Empresa/Index")) {
        Empresa.Listar();
    };

})
