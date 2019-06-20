﻿using JBD.MonitorCozinha.Domain.Entitys;
using System.Collections.Generic;

namespace JBD.MonitorCozinha.Domain.Interfaces.Repository
{
    public interface IEmpresaRepository
    {
        List<EmpresaEntity> ListarEmpresas();
        List<EmpresaEntity> ListarEmpresas(string nome, string cnpjcpf);
        EmpresaEntity ObterEmpresaById(int Id);
        bool VeficaDuplicidadeCnpjCpf(string cnpjcpf);
        void Salvar(EmpresaEntity empresa);
        void Deletar(int Id);
    }
}
