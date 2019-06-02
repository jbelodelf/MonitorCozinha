using System;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class EmpresaModel
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

        //public List<PessoaEntity> Contatos { get; set; }
        //public List<UnidadeEntity> Unidades { get; set; }
    }
}
