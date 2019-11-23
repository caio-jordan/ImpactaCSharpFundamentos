using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentos.Capitulo08.VetoresColecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            // esta adiocionando 
            var inteiros = new List<int>(/*1000*/) {1, 8, 33, 16, -78, 16 };
            //como o metodo add voce adiciona um inteiro na sua list
            inteiros.Add(27);
            inteiros.Add(-8);

            var maisInteiros = new List<int> {16, 38, -7, 16, 16 };

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(2, 42);
            inteiros.Remove(42); //Remove apenas a primeira ocorrência do item
            inteiros.RemoveAll(inteiro => inteiro == 16);// Lâmbda Expression
            inteiros.RemoveAt(5);//Remover a possicao do vetor
            inteiros.Sort();

            var primeiro = inteiros[0];
            primeiro = inteiros.First();

            var ultimo = inteiros[inteiros.Count - 1];
            inteiros.Last();

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}:{inteiro}");
            }
        }
        [TestMethod]
        public void DicttionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2019, 11, 15), "Proclamação da República");
            feriados.Add(Convert.ToDateTime("20/11/2019"), "Conciência Negra");
            feriados.Add(Convert.ToDateTime("25/01/2020"), "Aniversário de São Paulo");

            var proclamacao = feriados[new DateTime(2019, 11, 15)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToShortDateString()}:{feriado.Value}"); 
            }

            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("20/11/2019")));
            Console.WriteLine(feriados.ContainsValue("Proclamação da República"));
        }
    }
}
