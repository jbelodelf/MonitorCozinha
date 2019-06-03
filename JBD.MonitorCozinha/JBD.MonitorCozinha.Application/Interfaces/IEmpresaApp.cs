using JBD.MonitorCozinha.Domain.Entitys;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.Application.Interfaces
{
    public interface IEmpresaApp
    {
        List<EmpresaEntity> ListarEmpresas();
        List<EmpresaEntity> ListarEmpresas(string nome, string cnpjcpf);
        EmpresaEntity ObterEmpresaById(int Id);
        void Salvar(EmpresaEntity empresa);
        void Deletar(int Id);
    }
}
