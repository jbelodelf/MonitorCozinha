﻿using System;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.Domain.DTOS
{
    public class EmpresaDTO
    {
        public int IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public int IdContatoPrincipal { get; set; }
        public int IdContatoSecundario { get; set; }
        public int IdStatus { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<PessoaDTO> Contatos { get; set; }
        public List<UnidadeDTO> Unidades { get; set; }
    }
}
