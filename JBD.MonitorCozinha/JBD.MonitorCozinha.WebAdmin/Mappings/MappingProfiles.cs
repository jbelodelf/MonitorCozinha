using AutoMapper;
using JBD.MonitorCozinha.Domain.DTOS;
using JBD.MonitorCozinha.Domain.Entitys;
using JBD.MonitorCozinha.WebAdmin.Models;

namespace JBD.MonitorCozinha.WebAdmin.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<EmpresaEntity, EmpresaDTO>().ReverseMap();
            CreateMap<EmpresaDTO, EmpresaModel>().ReverseMap();


        }
    }
}
