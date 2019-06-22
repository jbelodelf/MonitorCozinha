Empresa = {
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
            $("#colNome").css("width", "680");
            AplicarDataTable('tbListarEmpresas', '0', "asc", 20, false, undefined, true);
            $("#tbListarEmpresas").css("margin-top", "5px");
            $("#tbListarEmpresas").css("float", "right");
            $("#footer").css("margin-top", "50px");
            $("#footer").css("height", "40px");
            $("#footer").css("padding", "10px");
            $("#tbListarEmpresas_length").parent().css("display", "contents");
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    },

    Salvar: function () {
        var isValido = true;
        if ($("#RazaoSocial").val() == "") {
            isValido = false;
        }
        else if ($("#NomeFantasia").val() == "") {
            isValido = false;
        }
        else if ($("#CNPJ").val() == "") {
            isValido = false;
        }
        else if ($("#InscricaoEstadual").val() == "") {
            isValido = false;
        }
        else if ($("#InscricaoMunicipal").val() == "") {
            isValido = false;
        }
        else if ($("#IdStatus").val() == "") {
            isValido = false;
        }
        else if ($("#DataCadastro").val() == "") {
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
                var url = "/Empresa/SalvarEmpresa";

                var cnpj = $("#CNPJ").val().replace(/\D/g, '');

                empresa = {
                    IdEmpresa: $("#IdEmpresa").val(),
                    RazaoSocial: $("#RazaoSocial").val(),
                    NomeFantasia: $("#NomeFantasia").val(),
                    CNPJ: cnpj,
                    InscricaoEstadual: $("#InscricaoEstadual").val(),
                    InscricaoMunicipal: $("#InscricaoMunicipal").val(),
                    IdStatus: $("#IdStatus").val(),
                    DataCadastro: $("#DataCadastro").val()
                };
                $.ajax({
                    url: url
                    , datatype: "json"
                    , type: "POST"
                    , async: false
                    , data: { empresa: empresa }
                    , cache: false
                }).done(function (data) {
                    if (data.retorno == "200") {
                        $("#mensagemModal").text(data.mensagem).show();
                        window.setTimeout(function () {
                            $("#mensagemModal").text("").hide();
                            window.location.href = "/Empresa";
                        }, 3000);
                    }
                    else {
                        $("#mensagemModal").text('Erro:' + data.mensagem).show();
                        window.setTimeout(function () {
                            $("#mensagemModal").text("").hide();
                            window.location.href = "/Empresa";
                        }, 3000);
                        return;
                    }
                }).fail(function (jqXHR, exception) {
                    TratamentoDeErro(jqXHR, exception);
                });
            }
        });
    },

    Editar: function (idEmpresa) {
        var url = "/Empresa/EditarEmpresa";
        $.ajax({
            url: url
            , datatype: "json"
            , type: "GET"
            , async: false
            , data: { id: idEmpresa }
            , cache: false
        }).done(function (data) {
            if (data != null) {
                $("#IdEmpresa").val(data.data.idEmpresa);
                $("#RazaoSocial").val(data.data.razaoSocial);
                $("#NomeFantasia").val(data.data.nomeFantasia);
                $("#CNPJ").val(data.data.cnpj);
                $("#InscricaoEstadual").val(data.data.inscricaoEstadual);
                $("#InscricaoMunicipal").val(data.data.inscricaoMunicipal);
                $("#IdStatus").val(data.data.idStatus);
                $("#DataCadastro").val(data.data.dataCadastro);

                $("#btnSalvarEmpresa").show();
                $("#ModalCadastrarEmpresa").modal('show');
            }
            else {
                return;
            }
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    },

    ListarUnidade: function (id) {
        window.location.href = "/Unidade/Index?IdEmpresa=" + id;
    },

    VerificaDuplicidadeCPF: function (cpfcnpj) {
        if ($("#CNPJ").val().length = 0) {
            return;
        }

        var url = "/Empresa/VeficaDuplicidadeCnpjCpf";
        $.ajax({
            url: url
            , datatype: "json"
            , type: "GET"
            , async: false
            , data: { cnpjcpf: cpfcnpj }
            , cache: false
        }).done(function (data) {
            if (data.retorno == "200") {
                if (data.duplicado) {
                    $("#mensagemModal").text(data.mensagem).show();
                    window.setTimeout(function () {
                        $("#mensagemModal").text("").hide();
                    }, 3000);
                    $("#CNPJ").focus();
                }
                else if (data.valido) {
                    $("#mensagemModal").text("").hide();
                }

            }
            else {
                $("#mensagemModal").text('Erro' + data.mensagem).show();
                window.setTimeout(function () {
                    $("#mensagemModal").text("").hide();
                }, 3000);
                return;
            }
        }).fail(function (jqXHR, exception) {
            TratamentoDeErro(jqXHR, exception);
        });
    },

}

//Carregar grid quando o documento é acessado conforme endereço passado
$(document).ready(function () {
    var url = window.location.pathname;
    if ((url == "/") || (url == "/Empresa") || (url =="/Empresa/Index") || (url == "/Empresa/")){
        Empresa.Listar();
    };

    $("#btnSalvarEmpresa").on("click", function () {
        Empresa.Salvar();
    });

    $('#btNovo').on("click", function () {

        $("#IdEmpresa").val("0");
        $("#RazaoSocial").val("").attr("Readonly", false);
        $("#NomeFantasia").val("").attr("Readonly", false);
        $("#CNPJ").val("").attr("Readonly", false);
        $("#InscricaoEstadual").val("").attr("Readonly", false);
        $("#InscricaoMunicipal").val("").attr("Readonly", false);
        $("#IdStatus").val("1").attr("Readonly", true);
        $("#DataCadastro").attr("Readonly")

        $("#btnSalvarEmpresa").show();
        $("#ModalCadastrarEmpresa").modal('show');

    });

    $('#btnFecharEmpresa').on("click", function () {

        $("#IdEmpresa").val("0");
        $("#RazaoSocial").val("")
        $("#NomeFantasia").val("")
        $("#CNPJ").val("")
        $("#InscricaoEstadual").val("")
        $("#InscricaoMunicipal").val("")
        $("#IdStatus").val("1")
        $("#DataCadastro").val("")

        $("#ModalCadastrarEmpresa").modal('hide');

    });

    $('#btPesquisar').on("click", function () {
        Empresa.Listar();

    });

    $("#CNPJ").blur(function () {
        if ($("#CNPJ").val() == "") {
            return;
        }
        else if ($("#CNPJ").val().length < 11) {
            $("#mensagemModal").text("Número inválido.").show();
            $("#CNPJ").focus();

            window.setTimeout(function () {
                $("#mensagemModal").text("").hide();
            }, 2000);
            return;
        }
        else if ($("#CNPJ").val().length == 14) {
            var valido = validarCPF($("#CNPJ").val())
            if (!valido) {
                $("#mensagemModal").text("Número de CPF inválido.").show();
                $("#CNPJ").focus();

                window.setTimeout(function () {
                    $("#mensagemModal").text("").hide();
                }, 2000);
                return;
            }
        }
        else if ($("#CNPJ").val().length > 14) {
            var valido = ValidarCNPJ($("#CNPJ").val())
            if (!valido) {
                $("#mensagemModal").text("Número de CNPJ inválido.").show();
                $("#CNPJ").focus();

                window.setTimeout(function () {
                    $("#mensagemModal").text("").hide();
                }, 2000);
                return;
            }
            
        }

        var cnpj = $("#CNPJ").val().replace(/\D/g, '');

        Empresa.VerificaDuplicidadeCPF(cnpj);

    });

    $("#CNPJ").focusout(function () {
        $("#CNPJ").unmask();
        var tamanho = $("#CNPJ").val().replace(/\D/g, '').length;
        if (tamanho == 11) {
            $("#CNPJ").mask("999.999.999-99");
        } else if (tamanho == 14) {
            $("#CNPJ").mask("99.999.999/9999-99");
        }
    });

})


