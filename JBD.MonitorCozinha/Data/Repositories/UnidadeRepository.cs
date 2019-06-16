using Data.Repositories.Base;
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
    public class UnidadeRepository : IUnidadeRepository
    {
        //Delete Unidade
        public void Deletar(int Id)
        {
            Expression<Func<UnidadeEntity, bool>> expressionFiltro = (a => a.IdStatus != (int)StatusEnum.Excluido && a.IdUnidade == (Int64)Id);

            using (var rep = new RepositoryBase<UnidadeEntity>())
            {
                UnidadeEntity unidade = rep.Select(expressionFiltro).FirstOrDefault();
                if (unidade != null)
                {
                    rep.Delete(unidade);
                }
            }
        }

        //List Unidades
        public List<UnidadeEntity> ListarUnidades()
        {
            List<UnidadeEntity> ListaUnidades = new List<UnidadeEntity>();
            string[] includes = new string[] { "Pessoas" };
            Expression<Func<UnidadeEntity, bool>> expressionFiltro = (a => a.IdStatus != (int)StatusEnum.Excluido);

            using (var rep = new RepositoryBase<UnidadeEntity>())
            {
                ListaUnidades = rep.Select(expressionFiltro, includes).ToList();
            }

            return ListaUnidades;
        }

        //Get Unidades By Id
        public UnidadeEntity ObterUnidadeById(int Id)
        {
            UnidadeEntity unidade = new UnidadeEntity();
            string[] includes = new string[] { "Pessoas" };
            Expression<Func<UnidadeEntity, bool>> expressionFiltro = (a => a.IdStatus != (int)StatusEnum.Excluido && a.IdUnidade == (Int64)Id);

            using (var rep = new RepositoryBase<UnidadeEntity>())
            {
                unidade = rep.Select(expressionFiltro, includes).FirstOrDefault();
            }

            return unidade;
        }

        public void Salvar(UnidadeEntity unidade)
        {
            using (var rep = new RepositoryBase<UnidadeEntity>())
            {
                if (unidade.IdUnidade == 0)
                {
                    rep.Insert(unidade);
                }
                else
                {
                    rep.Update(unidade);
                }
            }
        }
    }
}
