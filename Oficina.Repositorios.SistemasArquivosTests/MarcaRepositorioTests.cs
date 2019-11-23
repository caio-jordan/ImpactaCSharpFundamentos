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
    public class MarcaRepositorioTests
    {
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();

        [TestMethod()]
        public void ObterTest()
        {
            var marcas = marcaRepositorio.Obter();

            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.Id} - {marca.Nome}");
            }
        }
            [TestMethod]
        public void ObterPorIdteste()
        {
            var marca = marcaRepositorio.Obter(1);
            Assert.AreEqual(marca.Nome, "Fiat");

            marca = marcaRepositorio.Obter(0);
            Assert.IsNull(marca);
        }
        
    }
}