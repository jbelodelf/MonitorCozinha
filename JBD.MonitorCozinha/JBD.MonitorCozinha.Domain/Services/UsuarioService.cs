using JBD.MonitorCozinha.Domain.Entitys;
using JBD.MonitorCozinha.Domain.Interfaces.Repository;
using JBD.MonitorCozinha.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository _repository = null;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public void Deletar(int Id)
        {
            _repository.Deletar(Id);
        }

        public List<UsuarioEntity> ListarUsuarios()
        {
            return _repository.ListarUsuarios();
        }

        public UsuarioEntity ObterUsuarioById(int Id)
        {
            return _repository.ObterUsuarioById(Id);
        }

        public void Salvar(UsuarioEntity usuario)
        {
            _repository.Salvar(usuario);
        }
    }
}
