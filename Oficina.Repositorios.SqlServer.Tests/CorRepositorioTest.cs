// <copyright file="CorRepositorioTest.cs">Copyright ©  2019</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SqlServer;

namespace Oficina.Repositorios.SqlServer.Tests
{
    /// <summary>This class contains parameterized unit tests for CorRepositorio</summary>
    [PexClass(typeof(CorRepositorio))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CorRepositorioTest
    {
        /// <summary>Test stub for Atualizar(Cor)</summary>
        [PexMethod]
        public void AtualizarTest([PexAssumeUnderTest]CorRepositorio target, Cor cor)
        {
            target.Atualizar(cor);
            // TODO: add assertions to method CorRepositorioTest.AtualizarTest(CorRepositorio, Cor)
        }
    }
}
