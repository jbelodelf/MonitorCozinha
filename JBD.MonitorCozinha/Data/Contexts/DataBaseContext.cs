using JBD.MonitorCozinha.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(StringConectionConfig());
            }
        }

        public DbSet<EmpresaEntity> Empresa { get; set; }

        private string StringConectionConfig()
        {
            return "Server=DESKTOP-24V97RI;Database=DB_MONITOR_COZINHA;User Id=sa;Password=mbelo;MultipleActiveResultSets=true;Encrypt=YES;TrustServerCertificate=YES";
        }
    }
}
