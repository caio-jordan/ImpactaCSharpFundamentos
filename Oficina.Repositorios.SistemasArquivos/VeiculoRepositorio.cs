using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorios.SistemasArquivos
{
    public class VeiculoRepositorio
    {
        private static string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoVeiculo"];
        private XDocument arquivoXml = XDocument.Load(caminhoArquivo);

        public void Inserir(Veiculo veiculo)
        {
            var registro = new StringWriter();
            var serializador = new XmlSerializer(typeof(Veiculo));

            serializador.Serialize(registro, veiculo);
            
            arquivoXml.Root.Add(XElement.Parse(registro.ToString()));
            arquivoXml.Save(caminhoArquivo);
        }
    }
}
