
$(document).ready(function () {

    $("#btnEnviar").on("click", function () {

        let idSuspeito = $("#Suspeito_Id").val();
        let idLocal = $("#Local_Id").val();
        let idArma = $("#Arma_Id").val();

        if (idArma != "" && idLocal != "" && idSuspeito != "") {

            requisicao("/Detetive/Testemunha/" + idArma + "/" + idLocal + "/" + idSuspeito, "GET").done(function (retorno) {

                let resposta;

                if (retorno.flSucesso) {

                    switch (retorno.testemunha) {

                        case enum_resposta_testemunha.correto:

                            bootbox.confirm({
                                title: 'Parabéns pela solução do caso!',
                                message: 'Quer iniciar o questionamento para a testemunha novamente?',
                                buttons: {
                                    cancel: {
                                        label: '<i class="fa fa-times"></i> Cancelar'
                                    },
                                    confirm: {
                                        label: '<i class="fa fa-check"></i> Confirmar'
                                    }
                                },
                                callback: function (result) {

                                    if (result) {
                                        window.location.reload();
                                    }                                    
                                }
                            });

                            return;
                            break;

                        case enum_resposta_testemunha.assassino_incorreto:
                            resposta = "O Assassino está incorreto";
                            break;

                        case enum_resposta_testemunha.local_incorreto:
                            resposta = "O Local está Incorreto";
                            break;

                        case enum_resposta_testemunha.arma_incorreta:
                            resposta = "A Arma Está Incorreta";
                            break;

                        default:
                            break;
                    }

                    bootbox.alert(resposta);
                }
            })
        }
        else {

            bootbox.alert("Selecione todos os parâmetros");
        }
    })










})