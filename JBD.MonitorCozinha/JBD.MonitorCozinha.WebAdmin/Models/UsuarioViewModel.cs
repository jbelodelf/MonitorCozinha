﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public int IdPessoa { get; set; }
        public int IdUnidade { get; set; }
        public int IdEmpresa { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IdStatus { get; set; }
        public int IdTipo { get; set; }
        public DateTime DataCadastro { get; set; }

        public PessoaViewModel Pessoa { get; set; }
    }
}
