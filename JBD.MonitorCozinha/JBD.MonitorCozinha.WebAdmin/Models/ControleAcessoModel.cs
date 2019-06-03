using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class ControleAcessoModel
    {
        public int IdControleAcesso { get; set; }
        public int IdUsuario { get; set; }
        public int IdUnidade { get; set; }
        public int IdEmpresa { get; set; }
        public string IP { get; set; }
        public DateTime DataLogin { get; set; }
        public DateTime DataLogoff { get; set; }
        public bool ConexaoAtiva { get; set; }

    }
}
