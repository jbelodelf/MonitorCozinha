using JBD.MonitorCozinha.Domain.Entitys;
using JBD.MonitorCozinha.Domain.Interfaces.Repository;
using JBD.MonitorCozinha.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Domain.Services
{
    public class EmpresaService : IEmpresaService
    {
        IEmpresaRepository _repository = null;

        public EmpresaService(IEmpresaRepository repository)
        {
            _repository = repository;
        }

        public List<EmpresaEntity> ListarEmpresas()
        {
            return _repository.ListarEmpresas();
        }
    }
}
