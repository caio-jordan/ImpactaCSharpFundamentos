using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemasArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemasArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {

        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();


        [TestMethod()]
        public void ObterTest()
        {
            var modelos = modeloRepositorio.ObterPorMarca(4);

            foreach (var modelo in modelos)
            {
                Console.WriteLine($"{modelo.Id} - {modelo.Nome} - {modelo.Marca.Nome}");
            }
        }

        [TestMethod()]
        public void ObterPorIdTest()
        {
            var modelo = modeloRepositorio.Obter(1);
            Assert.AreEqual(modelo.Nome, "Argo");

            modelo = modeloRepositorio.Obter(0);
            Assert.IsNull(modelo);
        }
    }
}