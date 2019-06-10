using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class PessoaViewModel
    {
        public int IdPessoa { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUnidade { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Cargo { get; set; }
        public string EmailPJ { get; set; }
        public string EmailPF { get; set; }
        public int IdStatus { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<TelefoneViewModel> Telefones { get; set; }

    }
}
