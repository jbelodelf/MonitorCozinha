﻿using JBD.MonitorCozinha.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Application.Interfaces
{
    public interface IPessoaApp
    {
        List<PessoaEntity> ListarPessoas();
        PessoaEntity ObterPessoaById(int Id);
        void Salvar(PessoaEntity pessoa);
        void Deletar(int Id);
    }
}
