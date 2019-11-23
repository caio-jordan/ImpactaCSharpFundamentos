using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFundamentos.Capitulo05.Repeticao.Testes
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void TabuadaTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine(new string('-',50));
            }
        }
        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;

            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i))
            {
               // i++;
            }

            /*
              for(1. Inicialização; 2. booleano "critério, condição"; 4. Pós-Execução)
              {
                3. Execução;
              }
             */
        }

        [TestMethod]
        public void ForApenasComCondiçãoTeste()
        {
            var i = 1;

            for (; i <=3;)
            {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTeste()
        {
            for (int i = 1; i <= 10 ; i++)
            {
                if (i <= 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void BreakTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
