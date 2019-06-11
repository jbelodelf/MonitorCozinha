using System;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class EmpresaViewModel
    {
        public int IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public int IdStatus { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<UnidadeViewModel> Unidades { get; set; }
    }
}
