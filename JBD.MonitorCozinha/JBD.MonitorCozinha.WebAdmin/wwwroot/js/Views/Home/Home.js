Home = {
    InserirNumero: function () {
        var IdEmpresa = $("#IdEmpresa").val();
        var IdUnidade = $("#IdUnidade").val();
        var NumeroPedido = $("#NumeroPedido").val();

        var url = "/MonitorAdmin/InserirNumeroPedido";
        $.ajax({
            url: url
            , datatype: "json"
            , type: "POST"
            , async: false
            , data: { IdEmpresa: IdEmpresa, IdUnidade: IdUnidade, NumeroPedido: NumeroPedido }
            , cache: false
        }).done(function (data) {
            if (data.resultado == true) {
                window.setTimeout(function () {
                   $("#ModalCadastrarNumero").modal('hide');
                }, 500);
            }
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    },

    Cadastrar: function (idEmpresa, idUnidade) {
        $("#IdUnidade").val(idUnidade);
        $("#ModalCadastrarNumero").modal('show');
    }
}

$(document).ready(function () {
    $("#btnFecharNumeroPedido").click(function () {
        $("#ModalCadastrarNumero").modal('hide');
    })

    $("#btnSalvarNumeroPedido").click(function () {
        Home.InserirNumero();
    })
})