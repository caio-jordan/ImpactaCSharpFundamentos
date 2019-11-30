using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio.Tests
{
    [TestClass()]
    public class FreteTests
    {
        [TestMethod()]
        public void FreteTest()
        {
            var frete = new Frete(100,UF.SP);

        //    frete.Valor = 100;
        //    frete.UF = UF.SP;

          //  frete.Calcular();

            Assert.AreEqual(frete.Percentual, 0.2m);
            Assert.IsTrue(frete.Total == 120);
           // Console.WriteLine(frete.Percentual);
            
        }
    }
}