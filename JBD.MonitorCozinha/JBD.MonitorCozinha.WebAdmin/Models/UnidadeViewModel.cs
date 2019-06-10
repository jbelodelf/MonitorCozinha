using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JBD.MonitorCozinha.WebAdmin.Models
{
    public class UnidadeViewModel
    {
        public int IdUnidade { get; set; }
        public int IdEmpresa { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int IdContatoPrincipal { get; set; }
        public int IdContatoSecundario { get; set; }
        public int IdStatus { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<NumeroPedidoViewModel> NumeroPedidos { get; set; }
        public List<PessoaViewModel> Pessoas { get; set; }

    }
}
