using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemasArquivos
{
    public class MarcaRepositorio
    {
        private string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoMarca"]; // private um elemento que só existe dentro da classe | cm para ler o arquivo de configuração

        public List<Marca> Obter() 
        {
            var marcas = new List<Marca>(); 

            foreach (var linha in File.ReadAllLines(caminhoArquivo)) 
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var propriedades = linha.Split('|'); //Split(Cortar) retorna o vetor e como parâmetro solicita o separador neste caso '|'.

                var marca = new Marca();

                marca.Id = Convert.ToInt32(propriedades [0]); 
                marca.Nome = propriedades [1];

                marcas.Add(marca);
            }

            return marcas;
        }

        public Marca Obter(int id)
        {
            Marca marca = null;

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }
                var propriedades = linha.Split('|');
                var linhaId = Convert.ToInt32( propriedades [0] );

                if (id == linhaId)
                {
                    marca = new Marca();

                    marca.Id = linhaId;
                    marca.Nome = propriedades [1];
                    break;
                }
            }

            return marca;
        }
    }
}
