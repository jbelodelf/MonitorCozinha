using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Domain.DTOS
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public int IdPessoa { get; set; }
        public int IdUnidade { get; set; }
        public int IdEmpresa { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IdStatus { get; set; }
        public DateTime DataCadastro { get; set; }

        //public PessoaEntity Pessoa { get; set; }

    }
}
