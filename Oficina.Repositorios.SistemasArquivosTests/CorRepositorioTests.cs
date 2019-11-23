using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Oficina.Repositorios.SistemasArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        CorRepositorio corRepositorio = new CorRepositorio();

        [TestMethod()]
        public void ObterTest()
        {        
            var cores = corRepositorio.Obter();

            foreach (var cor in cores)
            {
                Console.WriteLine($"{cor.Id} - {cor.Nome}");
            }
        }

        [TestMethod()]
        public void ObterPorIdTest()
        {
            var cor = corRepositorio.Obter(3);

            Assert.AreEqual(cor.Nome, "Branco");

            cor = corRepositorio.Obter(0);
            Assert.IsNull(cor);

        }
    }
}