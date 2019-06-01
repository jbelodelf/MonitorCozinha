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
            return "Server=DESKTOP-IANDO4A;Initial Catalog=DB_MONITOR_COZINHA;User ID=sa;Password=sqlserver2016;Integrated Security=False;Connect Timeout=15;Encrypt=False;Trusted_Connection=True";
        }
    }
}
