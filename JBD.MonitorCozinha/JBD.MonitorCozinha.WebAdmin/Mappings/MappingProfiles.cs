using AutoMapper;
using JBD.MonitorCozinha.Domain.DTOS;
using JBD.MonitorCozinha.WebAdmin.Models;

namespace JBD.MonitorCozinha.WebAdmin.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<EmpresaDTO, EmpresaModel>().ReverseMap();
            CreateMap<ControleAcessoDTO, ControleAcessoModel>().ReverseMap();
            CreateMap<NumeroPedidoDTO, NumeroPedidoModel>().ReverseMap();
            CreateMap<PessoaDTO, PessoaModel>().ReverseMap();
            CreateMap<StatusDTO, StatusModel>().ReverseMap();
            CreateMap<StatusPedidoDTO, StatusPedidoModel>().ReverseMap();
            CreateMap<TelefoneDTO, TelefoneModel>().ReverseMap();
            CreateMap<UnidadeDTO, UnidadeModel>().ReverseMap();
            CreateMap<UsuarioDTO, UsuarioModel>().ReverseMap();


        }
    }
}
