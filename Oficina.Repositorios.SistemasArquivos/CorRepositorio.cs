using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;

namespace Oficina.Repositorios.SistemasArquivos
{
    public class CorRepositorio
    {
        public List<Cor> Obter() //Get,Isert,Pesquisar vai depender do programador
        {
            var cores = new List<Cor>(); //Objeto cores é uma instância da classe list

            foreach (var linha in File.ReadAllLines("Dados\\Cor.txt")) //ou @"Dados\\Cor.txt" para resolver o problema de pegar o / do CSHARP
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }
                var cor = new Cor();

                cor.Id = Convert.ToInt32( linha.Substring(0, 5)); // metodo(Subtring) para analizar partes do texto, onde a string começa e o tamanho onde termina
                cor.Nome = linha.Substring(5); // Pode ser declarado com um item

                cores.Add(cor);
            }

            return cores;
        }

        public Cor Obter(int id)
        {
            Cor cor = null;

            foreach (var linha in File.ReadAllLines("Dados\\Cor.txt")) 
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var linhaId = Convert.ToInt32(linha.Substring(0, 5));

                if (id == linhaId)
                {
                    cor = new Cor();

                    cor.Id = linhaId;
                    cor.Nome = linha.Substring(5);
                    break;
                }
            }

            return cor;
        }
    }
}
