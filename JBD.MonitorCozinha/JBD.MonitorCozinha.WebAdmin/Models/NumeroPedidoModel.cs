using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class NumeroPedidoModel
    {
        public int IdNumeroPedido { get; set; }
        public int IdUnidade { get; set; }
        public int IdEmpresa { get; set; }
        public string NumeroPedido { get; set; }
        public int IdStatusPedido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataFinalizacao { get; set; }

    }
}
