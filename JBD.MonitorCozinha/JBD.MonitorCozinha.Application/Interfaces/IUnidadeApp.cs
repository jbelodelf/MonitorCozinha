using JBD.MonitorCozinha.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Application.Interfaces
{
    public interface IUnidadeApp
    {
        List<UnidadeEntity> ListarUnidades();
        UnidadeEntity ObterUnidadeById(int Id);
        void Salvar(UnidadeEntity unidade);
        void Deletar(int Id);

    }
}
