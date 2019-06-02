using Data.Reositories;
using JBD.MonitorCozinha.Application.Interfaces;
using JBD.MonitorCozinha.Application.Repositories;
using JBD.MonitorCozinha.Domain.Interfaces.Repository;
using JBD.MonitorCozinha.Domain.Interfaces.Service;
using JBD.MonitorCozinha.Domain.Services;
using System;
using Xunit;

namespace JBD.MonitorCozinha.Test.Admin
{
    public class UnitTest1
    {
        //private readonly EmpresaController _controller;
        private readonly IEmpresaApp _repositoryApp;
        private readonly IEmpresaRepository _repository;
        private readonly IEmpresaService _service;

        public UnitTest1()
        {
            _repository = new EmpresaRepository();
            _service = new EmpresaService(_repository);
            _repositoryApp = new EmpresaRepositoryApp(_service);
            //_controller = new EmpresaController(_repositoryApp);
        }

        //[Fact]
        //public async void Test1()
        //{
        //    // Act
        //    var data = await _controller.Get();

        //    // Assert
        //    Assert.IsType<OkObjectResult>(data.Result);
        //    var okResult = data.Result.Should().BeOfType<OkObjectResult>().Subject;
        //    var post = okResult.Value.Should().BeAssignableTo<List<Funcionario>>().Subject;
        //    Assert.Equal(4, post.Count);
        //}


        //[Fact]
        //public async void Test2()
        //{
        //    // Act
        //    var data = await _controller.Get();

        //    // Assert
        //    Assert.IsType<OkObjectResult>(data.Result);
        //    var okResult = data.Result.Should().BeOfType<OkObjectResult>().Subject;
        //    var post = okResult.Value.Should().BeAssignableTo<List<Funcionario>>().Subject;
        //    Assert.NotEqual(1, post.Count);
        //}

        [Fact]
        public void Test3()
        {

        }
    }
}
