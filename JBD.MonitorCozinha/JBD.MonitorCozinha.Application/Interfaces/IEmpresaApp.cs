using JBD.MonitorCozinha.Domain.Entitys;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.Application.Interfaces
{
    public interface IEmpresaApp
    {
        List<EmpresaEntity> ListarEmpresas();
        List<EmpresaEntity> ListarEmpresas(string nome, string cpdcpf);
        EmpresaEntity ObterEmpresaById(int Id);
        void Salvar(EmpresaEntity empresa);
        void Deletar(int Id);
    }
}
