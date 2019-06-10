using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class NumeroPedidoViewModel
    {
        public int IdNumeroPedido { get; set; }
        public int IdUnidade { get; set; }
        public int IdEmpresa { get; set; }
        public string NumeroPedido { get; set; }
        public int IdStatusPedido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataFinalizacao { get; set; }


        //public List<NumeroPedidoViewModel> ListarNumeroPedidos()
        //{
        //    List<NumeroPedidoViewModel> numeroPedidos = new List<NumeroPedidoViewModel>()
        //    {
        //        new NumeroPedidoViewModel(){IdNumeroPedido=1,IdUnidade=1,IdEmpresa=5,NumeroPedido="0123456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=2,IdUnidade=1,IdEmpresa=5,NumeroPedido="0123456789",IdStatusPedido=2,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=3,IdUnidade=1,IdEmpresa=5,NumeroPedido="0223456789",IdStatusPedido=3,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=4,IdUnidade=1,IdEmpresa=5,NumeroPedido="0323456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=5,IdUnidade=1,IdEmpresa=5,NumeroPedido="0423456789",IdStatusPedido=2,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=6,IdUnidade=1,IdEmpresa=5,NumeroPedido="0523456789",IdStatusPedido=3,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=7,IdUnidade=1,IdEmpresa=5,NumeroPedido="0623456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=8,IdUnidade=1,IdEmpresa=5,NumeroPedido="0723456789",IdStatusPedido=2,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=9,IdUnidade=1,IdEmpresa=5,NumeroPedido="0823456789",IdStatusPedido=3,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=10,IdUnidade=1,IdEmpresa=5,NumeroPedido="0923456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=11,IdUnidade=1,IdEmpresa=5,NumeroPedido="1023456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=12,IdUnidade=1,IdEmpresa=5,NumeroPedido="1123456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=13,IdUnidade=1,IdEmpresa=5,NumeroPedido="1223456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=14,IdUnidade=1,IdEmpresa=5,NumeroPedido="1323456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=15,IdUnidade=1,IdEmpresa=5,NumeroPedido="1423456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=16,IdUnidade=1,IdEmpresa=5,NumeroPedido="1523456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null},
        //        new NumeroPedidoViewModel(){IdNumeroPedido=17,IdUnidade=1,IdEmpresa=5,NumeroPedido="1623456789",IdStatusPedido=1,DataCadastro=DateTime.Now,DataFinalizacao=null}
        //    };

        //    return numeroPedidos;
        //}

    }
}
