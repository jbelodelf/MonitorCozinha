MonitorAdmin = {
    AtualizarStatus: function (idPedido, idStatus) {
        var url = "/MonitorAdmin/AlterarNumeroPedido";
        $.ajax({
            url: url
            , datatype: "json"
            , type: "GET"
            , async: false
            , data: { IdNumeroPedido: idPedido, Idstatus: idStatus }
            , cache: false
        }).done(function (data) {
            if (data.resultado == true) {
                window.setTimeout(function () {
                    window.location.href = "/MonitorAdmin/Index";
                }, 500);
            }
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    },

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
                    window.location.href = "/MonitorAdmin/Index";
                }, 500);
            }
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    },

    DeletarNumero: function (idPedido) {
        var url = "/MonitorAdmin/DeletarNumeroPedido";
        $.ajax({
            url: url
            , datatype: "json"
            , type: "GET"
            , async: false
            , data: { IdNumeroPedido: idPedido }
            , cache: false
        }).done(function (data) {
            if (data.resultado == true) {
                window.setTimeout(function () {
                    window.location.href = "/MonitorAdmin/Index";
                }, 500);
            }
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    }
}

$(document).ready(function () {
    $("#btCadastrarNumeroPedido").click(function () {
        $("#ModalCadastrarNumero").modal('show');
    })

    $("#btnFecharNumeroPedido").click(function () {
        $("#ModalCadastrarNumero").modal('hide');
    })

    $("#btnSalvarNumeroPedido").click(function () {
        MonitorAdmin.InserirNumero();
    })
})