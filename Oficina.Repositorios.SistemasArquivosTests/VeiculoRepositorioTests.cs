using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemasArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemasArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            //VeiculoRepositorio veiculoRepositorio = new VeiculoRepositorio();
            var veiculo = new VeiculoPasseio();

            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Carroceria = Carroceria.Hatch;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Observacao = "Completinho";
            veiculo.Placa = "ABC1234";

            var corRepositorio = new CorRepositorio();

            veiculo.Cor = corRepositorio.Obter(1);

            veiculo.Modelo = new ModeloRepositorio().Obter(1);

            new VeiculoRepositorio().Inserir(veiculo);


        }
    }
}