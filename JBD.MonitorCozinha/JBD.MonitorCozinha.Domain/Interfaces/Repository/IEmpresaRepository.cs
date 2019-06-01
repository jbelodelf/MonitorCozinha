using JBD.MonitorCozinha.Domain.Entitys;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.Domain.Interfaces.Repository
{
    public interface IEmpresaRepository
    {
        List<EmpresaEntity> ListarEmpresas();
    }
}
