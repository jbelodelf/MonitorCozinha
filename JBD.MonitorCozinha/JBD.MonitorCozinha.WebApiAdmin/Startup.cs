﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Reositories;
using Data.Repositories;
using Data.Repositories.Base;
using JBD.MonitorCozinha.Application.Interfaces;
using JBD.MonitorCozinha.Application.Repositories;
using JBD.MonitorCozinha.Domain.Interfaces.Repository;
using JBD.MonitorCozinha.Domain.Interfaces.Repository.Base;
using JBD.MonitorCozinha.Domain.Interfaces.Service;
using JBD.MonitorCozinha.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace JBD.MonitorCozinha.WebApiAdmin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper();

            services.AddSingleton(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            services.AddSingleton<IEmpresaApp, EmpresaRepositoryApp>();
            services.AddSingleton<INumeroPedidoApp, NumeroPedidoRepositoryApp>();

            services.AddSingleton<IEmpresaService, EmpresaService>();
            services.AddSingleton<INumeroPedidoService, NumeroPedidoService>();

            services.AddSingleton<IEmpresaRepository, EmpresaRepository>();
            services.AddSingleton<INumeroPedidoRepository, NumeroPedidoRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
