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

        public void Deletar(int Id)
        {
            _sevice.Deletar(Id);
        }

        public List<EmpresaEntity> ListarEmpresas()
        {
            return _sevice.ListarEmpresas();
        }

        public List<EmpresaEntity> ListarEmpresas(string nome, string cnpjcpf)
        {
            return _sevice.ListarEmpresas(nome, cnpjcpf);
        }

        public EmpresaEntity ObterEmpresaById(int Id)
        {
            return _sevice.ObterEmpresaById(Id);
        }

        public void Salvar(EmpresaEntity empresa)
        {
            _sevice.Salvar(empresa);
        }
    }
}
