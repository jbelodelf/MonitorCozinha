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


        }
    }
}
