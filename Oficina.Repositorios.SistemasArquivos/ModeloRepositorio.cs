using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemasArquivos
{
    public class ModeloRepositorio
    {
        private XDocument arquivoXml = XDocument.Load( ConfigurationManager.AppSettings["caminhoArquivoModelo"]); //O comando 'XDocument'' serve para manipular arquivos xml 
        //XDocument esta aguardando um arquivo xml para trabalhar. (Load)serve para carregar um arquivo xml

        public List<Modelo> ObterPorMarca(int marcaId) // a primeira linha do metodo é assinatura do metódo, se esquer de colocar o 'public' ele é private.
        {
            var modelos = new List<Modelo>();

            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                if (marcaId.ToString() == elemento.Element("marcaId").Value)
                {
                    var modelo = new Modelo(); //Instacia da classe
                    modelo.Id = Convert.ToInt32( elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;

                    var marcaRepositorio = new MarcaRepositorio();

                    modelo.Marca = marcaRepositorio.Obter(marcaId);

                    modelos.Add(modelo);
                }
            }

            return modelos;
        }

        public Modelo Obter(int id)
        {
            Modelo modelo = null;

            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                if (id.ToString() == elemento.Element("id").Value)
                {
                    modelo = new Modelo(); //Instacia da classe
                    modelo.Id = id;
                    modelo.Nome = elemento.Element("nome").Value;
                    
                    var marcaRepositorio = new MarcaRepositorio();

                    modelo.Marca = marcaRepositorio.Obter(Convert.ToInt32(elemento.Element("marcaId").Value));
                    break;
                }
            }



            return modelo;

        }
    }
}
