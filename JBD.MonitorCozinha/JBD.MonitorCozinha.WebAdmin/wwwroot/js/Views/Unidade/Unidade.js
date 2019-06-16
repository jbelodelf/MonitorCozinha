Unidade = {
    Listar: function () {
        $("body").css("padding-top", "2px", "!important");
        $("#TopoPesquisa").css("margin-left", "5px");
        $("#TopoPesquisa").css("margin-right", "5px");
        $("#TopoPesquisa").css("padding-top", "20px");
        $("#TopoPesquisa").css("padding-bottom", "15px");
        var unidade = $("#UnidadePesquisar").val();

        var url = "/Unidade/ListarUnidades";
        $.ajax({
            url: url
            , datatype: "json"
            , type: "GET"
            , async: false
            , data: { nomeUnidade: unidade }
            , cache: false
        }).done(function (data) {
            $("#divListarUnidades").html(data);

            $("#cabecalho").css("background-color", "#5B9BD5")
            $("#cabecalho").css("color", "#FFFFFF")
            $("#colNome").css("width", "680");
            AplicarDataTable('tbListarUnidades', '0', "asc", 20, false, undefined, true);
            $("#tbListarEmpresas").css("margin-top", "5px");
            $("#tbListarEmpresas").css("float", "right");
            $("#footer").css("margin-top", "50px");
            $("#footer").css("height", "40px");
            $("#footer").css("padding", "10px");
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    },

    Salvar: function () {
        var isValido = true;
        if ($("#IdEmpresa").val() == "") {
            isValido = false;
        }
        else if ($("#Nome").val() == "") {
            isValido = false;
        }
        else if ($("#CEP").val() == "") {
            isValido = false;
        }
        else if ($("#Endereco").val() == "") {
            isValido = false;
        }
        else if ($("#Bairro").val() == "") {
            isValido = false;
        }
        else if ($("#Cidade").val() == "") {
            isValido = false;
        }
        else if ($("#Estado").val() == "") {
            isValido = false;
        }
        else if ($("Pais").val() == "") {
            isValido = false;
        }
        else if ($("IdStatus").val() == "") {
            isValido = false;
        }
        else if ($("DataCadastro").val() == "") {
            isValido = false;
        }

        if (!isValido) {
            $("#mensagemModal").text("Favor preencher os campos obrigatórios!!!").show();
            window.setTimeout(function () {
                $("#mensagemModal").text("").hide();
            }, 6000);
            return;
        }
        bootbox.confirm({
            message: 'Deseja realmente salvar este registro?',
            buttons: {
                confirm: {
                    label: 'Sim',
                    className: 'btn-success'
                },
                cancel: {
                    label: 'Não',
                    className: 'btn-danger'
                }
            },
            callback: function (result) {
                if (!result) {
                    controle = true;
                    return;
                }
                var url = "/Unidade/SalvarUnidade";
                unidade = {
                    IdUnidade: $("#IdUnidade").val(),
                    IdEmpresa: $("#IdEmpresa").val(),
                    Nome: $("#Nome").val(),
                    CEP: $("#CEP").val(),
                    Endereco: $("#Endereco").val(),
                    Bairro: $("#Bairro").val(),
                    Cidade: $("#Cidade").val(),
                    Estado: $("#Estado").val(),
                    Pais: $("#Pais").val(),
                    IdStatus: $("#IdStatus").val(),
                    DataCadastro: $("#DataCadastro").val()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
                };
                $.ajax({
                    url: url
                    , datatype: "json"
                    , type: "POST"
                    , async: false
                    , data: { unidade: unidade }
                    , cache: false
                }).done(function (data) {
                    if (data.retorno == "200") {
                        $("#mensagemModal").text(data.mensagem).show();
                        window.setTimeout(function () {
                            $("#mensagemModal").text("").hide();
                            window.location.href = "/Unidade/Index";
                        }, 3000);
                    }
                    else {
                        $("#mensagemModal").text('Erro:' + data.mensagem).show();
                        window.setTimeout(function () {
                            $("#mensagemModal").text("").hide();
                            window.location.href = "/Unidade/Index";
                        }, 3000);
                        return;
                    }
                }).fail(function (jqXHR, exception) {
                    TratamentoDeErro(jqXHR, exception);
                });
            }
        });
    },

    Editar: function (idUnidade) {
        var url = "/Unidade/EditarUnidade";
        $.ajax({
            url: url
            , datatype: "json"
            , type: "GET"
            , async: false
            , data: { id: idUnidade }
            , cache: false
        }).done(function (data) {
            if (data != null) {
                $("#IdUnidade").val(data.data.idUnidade);
                $("#IdEmpresa").val(data.data.idEmpresa);
                $("#Nome").val(data.data.nome);
                $("#CEP").val(data.data.cep);
                $("#Endereco").val(data.data.endereco);
                $("#Bairro").val(data.data.bairro);
                $("#Cidade").val(data.data.cidade);
                $("#Estado").val(data.data.estado);
                $("#Pais").val(data.data.pais);
                $("#IdStatus").val(data.data.idStatus);
                $("#DataCadastro").val(data.data.dataCadastro);

                $("#btnSalvarUnidade").show();
                $("#ModalCadastrarUnidade").modal('show');
            }
            else {
                return;
            }
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    }
}

$(document).ready(function () {
    var url = window.location.pathname;
    if ((url == "/") || (url == "/Unidade") || (url == "/Unidade/Index") || (url == "/Unidade/")) {
        Unidade.Listar();
    }

    $("#btnSalvarUnidade").on("click", function () {
        Unidade.Salvar();
    });

    $('#btNovo').on("click", function () {

        $("#IdUnidade").val("0");
        $("#IdEmpresa").val("").attr("Readonly", false);
        $("#Nome").val("").attr("Readonly", false);
        $("#Endereco").val("").attr("Readonly", false);
        $("#Bairro").val("").attr("Readonly", false);
        $("#Cidade").val("").attr("Readonly", false);
        $("#Estado").val("").attr("Readonly", false);
        $("#Pais").val("").attr("Readonly", false);
        $("#IdStatus").val("1").attr("Readonly", true);
        $("#DataCadastro").attr("Readonly")

        $("#btnSalvarUnidade").show();
        $("#ModalCadastrarUnidade").modal('show');

    });

    $('#btnFecharUnidade').on("click", function () {

        $("#IdUnidade").val("0");
        $("#IdEmpresa").val("")
        $("#Nome").val("")
        $("#Endereco").val("")
        $("#Bairro").val("")
        $("#Cidade").val("")
        $("#Estado").val("")
        $("#Pais").val("")
        $("#IdStatus").val("")
        $("#DataCadastro").val("")

        $("#ModalCadastrarUnidade").modal('hide');

    });

});