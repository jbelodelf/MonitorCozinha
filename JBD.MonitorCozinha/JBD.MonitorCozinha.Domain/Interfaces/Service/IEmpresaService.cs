using JBD.MonitorCozinha.Domain.Entitys;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.Domain.Interfaces.Service
{
    public interface IEmpresaService
    {
        List<EmpresaEntity> ListarEmpresas();
    }
}
