using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class PessoaModel
    {
        public int IdPessoa { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUnidade { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public int Cargo { get; set; }
        public int EmailPJ { get; set; }
        public int EmailPF { get; set; }
        public int IdStatus { get; set; }
        public int DataCadastro { get; set; }

        //public List<TelefoneEntity> Telefones { get; set; }

    }
}
