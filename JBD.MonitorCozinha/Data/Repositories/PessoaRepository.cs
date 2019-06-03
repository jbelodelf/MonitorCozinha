﻿using Data.Repositories.Base;
using JBD.MonitorCozinha.Domain.Entitys;
using JBD.MonitorCozinha.Domain.Enuns;
using JBD.MonitorCozinha.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        //Delete Pessoa
        public void Deletar(int Id)
        {
            Expression<Func<PessoaEntity, bool>> expressionFiltro = (a => a.IdStatus != (int)StatusEnum.Excluido && a.IdPessoa == (Int64)Id);

            using (var rep = new RepositoryBase<PessoaEntity>())
            {
                PessoaEntity pessoa = rep.Select(expressionFiltro).FirstOrDefault();
                if (pessoa != null)
                {
                    rep.Delete(pessoa);
                }
            }

        }

        //List Pessoas
        public List<PessoaEntity> ListarPessoas()
        {
            List<PessoaEntity> ListaPessoas = new List<PessoaEntity>();
            string[] includes = new string[] { "Telefones" };
            Expression<Func<PessoaEntity, bool>> expressionFiltro = (a => a.IdStatus != (int)StatusEnum.Excluido);

            using (var rep = new RepositoryBase<PessoaEntity>())
            {
                ListaPessoas = rep.Select(expressionFiltro).ToList();
            }

            return ListaPessoas;
        }

        //Get By Id Pessoa
        public PessoaEntity ObterPessoaById(int Id)
        {
            PessoaEntity pessoa = new PessoaEntity();
            string[] includes = new string[] { "Telefone" };
            Expression<Func<PessoaEntity, bool>> expressionFiltro = (a => a.IdStatus != (int)StatusEnum.Excluido && a.IdPessoa == (Int64)Id);

            using (var rep = new RepositoryBase<PessoaEntity>())
            {
                pessoa = rep.Select(expressionFiltro).FirstOrDefault();
            }

            return pessoa;
        }

        public void Salvar(PessoaEntity pessoa)
        {
            using (var rep = new RepositoryBase<PessoaEntity>())
            {
                if (pessoa.IdPessoa == 0)
                {
                    rep.Insert(pessoa);
                }
                else
                {
                    rep.Update(pessoa);
                }
            }
        }
    }
}
