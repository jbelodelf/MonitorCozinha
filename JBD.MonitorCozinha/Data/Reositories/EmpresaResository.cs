using Data.Reositories.Base;
using JBD.MonitorCozinha.Domain.Entitys;
using JBD.MonitorCozinha.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Data.Reositories
{
    public class EmpresaResository : IEmpresaRepository
    {
        public List<EmpresaEntity> ListarEmpresas()
        {
            List<EmpresaEntity> ListaEmpresas = new List<EmpresaEntity>();

            using (var rep = new RepositoryBase<EmpresaEntity>())
            {
                ListaEmpresas = rep.Select().ToList();
            }

            return ListaEmpresas;
        }
    }
}
