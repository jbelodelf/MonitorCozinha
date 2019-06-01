using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace JBD.MonitorCozinha.Domain.Entitys
{
    [Table("TbEmpresa", Schema = "dbo")]
    public class EmpresaEntity
    {
        public EmpresaEntity()
        {
            Contatos = new List<PessoaEntity>().Where(p => p.IdPessoa == this.IdContatoPrincipal || p.IdPessoa == this.IdContatoSecundario).ToList();
            Unidades = new List<UnidadeEntity>();
        }

        [Key]
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

        public List<PessoaEntity> Contatos { get; set; }
        public List<UnidadeEntity> Unidades { get; set; }
    }
}
