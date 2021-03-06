﻿using JBD.MonitorCozinha.Application.Interfaces;
using JBD.MonitorCozinha.Domain.Entitys;
using JBD.MonitorCozinha.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Application.Repositories
{
    public class UsuarioRepositoryApp : IUsuarioApp
    {
        IUsuarioService _service = null;

        public UsuarioRepositoryApp(IUsuarioService service)
        {
            _service = service;
        }


        public void Deletar(int Id)
        {
            _service.Deletar(Id);
        }

        public List<UsuarioEntity> ListarUsuarios()
        {
            return _service.ListarUsuarios();
        }

        public UsuarioEntity ObterUsuarioById(int Id)
        {
            return _service.ObterUsuarioById(Id);
        }

        public void Salvar(UsuarioEntity usuario)
        {
            _service.Salvar(usuario);
        }
    }
}
