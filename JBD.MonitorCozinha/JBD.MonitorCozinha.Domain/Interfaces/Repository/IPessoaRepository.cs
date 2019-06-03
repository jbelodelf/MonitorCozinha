﻿using JBD.MonitorCozinha.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBD.MonitorCozinha.Domain.Interfaces.Repository
{
    public interface IPessoaRepository
    {
        List<PessoaEntity> ListarPessoas();
        PessoaEntity ObterPessoaById(int Id);
        void Salvar(PessoaEntity pessoa);
        void Deletar(int Id);

    }
}
