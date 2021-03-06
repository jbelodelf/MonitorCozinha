﻿using JBD.MonitorCozinha.Application.Interfaces;
using JBD.MonitorCozinha.Domain.Entitys;
using JBD.MonitorCozinha.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Application.Repositories
{
    public class UnidadeRepositoryApp : IUnidadeApp
    {
        IUnidadeService _service = null;

        public UnidadeRepositoryApp(IUnidadeService service)
        {
            _service = service;
        }
    
        public void Deletar(int Id)
        {
            _service.Deletar(Id);
        }

        public List<UnidadeEntity> ListarUnidades()
        {
            return _service.ListarUnidades();
        }

        public UnidadeEntity ObterUnidadeById(int Id)
        {
            return _service.ObterUnidadeById(Id);
        }

        public void Salvar(UnidadeEntity unidade)
        {
            _service.Salvar(unidade);
        }
    }
}
