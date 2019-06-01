using JBD.MonitorCozinha.Domain.Entitys;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.Application.Interfaces
{
    public interface IEmpresaApp
    {
        List<EmpresaEntity> ListarEmpresas();
    }
}
