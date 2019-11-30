using Oficina.Dominio;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorios.SistemasArquivos
{
    public class VeiculoRepositorio : RepositorioBase
    {
    //    private static string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoVeiculo"];
        private XDocument arquivoXml; //= XDocument.Load(caminhoArquivo); // Agora não prescisa mais do load. pois criamos uma BaseClasS

        public VeiculoRepositorio() : base("caminhoArquivoVeiculo")
        {
            arquivoXml = XDocument.Load(CaminhoArquivo);
        }

        public void Inserir<T>(T veiculo) where T: Veiculo
        {
            var registro = new StringWriter();
            var serializador = new XmlSerializer(typeof(T));

            serializador.Serialize(registro, veiculo);
            
            arquivoXml.Root.Add(XElement.Parse(registro.ToString()));
            arquivoXml.Save(CaminhoArquivo);
        }
    }
}
