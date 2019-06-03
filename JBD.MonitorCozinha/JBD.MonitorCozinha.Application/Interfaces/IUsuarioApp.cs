using JBD.MonitorCozinha.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Application.Interfaces
{
    public interface IUsuarioApp
    {
        List<UsuarioEntity> ListarUsuarios();
        UsuarioEntity ObterUsuarioById(int Id);
        void Salvar(UsuarioEntity usuario);
        void Deletar(int Id);

    }
}
