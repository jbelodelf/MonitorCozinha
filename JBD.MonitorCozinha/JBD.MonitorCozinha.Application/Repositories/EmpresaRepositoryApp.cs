using JBD.MonitorCozinha.Application.Interfaces;
using JBD.MonitorCozinha.Domain.Entitys;
using JBD.MonitorCozinha.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.Application.Repositories
{
    public class EmpresaRepositoryApp : IEmpresaApp
    {
        IEmpresaService _sevice = null;

        public EmpresaRepositoryApp(IEmpresaService sevice)
        {
            _sevice = sevice;
        }

        public List<EmpresaEntity> ListarEmpresas()
        {
            return _sevice.ListarEmpresas();
        }
    }
}
