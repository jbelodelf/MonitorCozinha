﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JBD.MonitorCozinha.Domain.Entitys
{
    [Table("TbUsuario", Schema = "dbo")]
    public class UsuarioEntity
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdPessoa { get; set; }
        public int IdUnidade { get; set; }
        public int IdEmpresa { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IdStatus { get; set; }
        public DateTime DataCadastro { get; set; }

        public PessoaEntity Pessoa { get; set; }
    }
}
