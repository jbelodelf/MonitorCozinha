using JBD.MonitorCozinha.Domain.Entitys;
using JBD.MonitorCozinha.Domain.Interfaces.Repository;
using JBD.MonitorCozinha.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.Domain.Services
{
    public class EmpresaService : IEmpresaService
    {
        IEmpresaRepository _repository = null;

        public EmpresaService(IEmpresaRepository repository)
        {
            _repository = repository;
        }

        public void Deletar(int Id)
        {
            _repository.Deletar(Id);
        }

        public List<EmpresaEntity> ListarEmpresas()
        {
            return _repository.ListarEmpresas();
        }

        public List<EmpresaEntity> ListarEmpresas(string nome, string cnpjcpf)
        {
            return _repository.ListarEmpresas(nome, cnpjcpf);
        }

        public EmpresaEntity ObterEmpresaById(int Id)
        {
            return _repository.ObterEmpresaById(Id);
        }

        public void Salvar(EmpresaEntity empresa)
        {
            _repository.Salvar(empresa);
        }

        public bool VeficaDuplicidadeCnpjCpf(string cnpjcpf)
        {
           return _repository.VeficaDuplicidadeCnpjCpf(cnpjcpf);
        }
    }
}
