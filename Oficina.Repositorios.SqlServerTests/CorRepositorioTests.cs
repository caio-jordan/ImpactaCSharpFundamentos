﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        private readonly CorRepositorio repositorio = new CorRepositorio();
        [TestMethod()]
        public void LerTest()
        {
            //var cor = "Branco";

            //Assert.IsTrue(cor =="Branco");

            var cores = repositorio.Ler();

            Assert.IsTrue(cores.Count > 0);
            Assert.IsTrue(cores.Any(x => x.Nome == "Branco"));
 
        }
        [TestMethod]
        public void LerPorIdTest()
        {
            Assert.IsTrue(repositorio.Ler(1).Nome == "Branco");
            Assert.IsNull(repositorio.Ler(0));
        }
    }
}