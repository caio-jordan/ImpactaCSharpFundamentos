using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using System.Text;

namespace CSharpFundamentos.Capitulo12.ValorReferencia
{
    [TestClass]
    public class ValorReferenciaTeste
    {
        [TestMethod]
        public void PassagemPorValorTeste()
        {
            var x = 1;

            Transformar(x);
            Assert.IsTrue(x == 1);
        }

        [TestMethod]
        public void PassagemPorReferencia()
        {
            var cor = new Cor();

            cor.Id = 1;
            cor.Nome = "Preto";

            Transformar(cor);
            Assert.AreEqual(cor.Nome, "Branco");   
        }

        [TestMethod]
        public void PassagemPorValorUsandoRefTeste()
        {
            var x = 1;
            Transformar(ref x);
            Assert.IsTrue(x == 2);
        }

        private void Transformar(ref int x)
        {
            ++x;
        }
        private void Transformar(Cor cor)
        {
            cor.Nome = "Branco";
        }

        [TestMethod]
        public void StringsSaoImutaveisTeste()
        {
            var texto = "aaa";
            string.Concat(texto, "a");
            texto.Replace("a", "b");

            Assert.IsTrue(texto == "aaa");

            texto = string.Concat(texto, "a");
            texto = texto.Replace("a", "b");
            Assert.AreEqual(texto,  "bbbb");

            var mutavel = new StringBuilder("aaa");

            mutavel.Append("a");
            mutavel.Replace("a", "b");
            Assert.AreEqual(mutavel.ToString(), "bbbb");

        }

        // [TestMethod]
        // public void StructTeste()
        // {
        //     var estrutura = new Estrutura();

        //     estrutura.Id = 1;
        //     Transformar(estrutura);
        //       }

        // private void Transformar(Estrutura estrutura);
        // {
        //     estrutura.Id = 1;
        // }

        //private struct Estrutura
        // {
        //     public int Id { get; set; }
        //     public string Nome { get; set; }
        // }
        [TestMethod]
        public void StructVsClassTeste()
        {
            var x = 42;
            Assert.IsTrue(x.GetType().IsValueType);
            var y = new int();
            y = 10;

            var meuObjeto = new object();
            Assert.IsTrue(meuObjeto.GetType().IsClass);

            var nome = "Lid";
            Assert.IsTrue(nome.GetType().IsClass);

        }

            //****** Editar depois******///

        private void Transformar(int x)
        {
            ++x;
        }
    }
}
