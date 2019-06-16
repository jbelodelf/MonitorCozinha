﻿using JBD.MonitorCozinha.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class EmpresaViewModel
    {
        public int IdEmpresa { get; set; }
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }
        [DisplayName("Inscrição Estadual")]
        public string InscricaoEstadual { get; set; }
        [DisplayName("Inscrição Municipal")]
        public string InscricaoMunicipal { get; set; }
        public int IdStatus { get; set; }
        [DisplayName("Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        public List<UnidadeViewModel> Unidades { get; set; }
        public DateTime dataNow = DateTime.Today; 
    }
}
