﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Domain.DTOS
{
    public class UnidadeDTO
    {
        public int IdUnidade { get; set; }
        public int IdEmpresa { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int IdContatoPrincipal { get; set; }
        public int IdContatoSecundario { get; set; }
        public int IdStatus { get; set; }
        public DateTime DataCadastro { get; set; }

        //public List<NumeroPedidoEntity> NumeroPedidos { get; set; }
        //public List<PessoaEntity> Pessoas { get; set; }
    }
}
