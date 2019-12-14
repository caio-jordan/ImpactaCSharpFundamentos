using Oficina.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficina.Dominio;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Oficina.Repositorios.SqlServer
{
    public class CorRepositorio : ICorRepositorio
    {
        private string stringConexao = ConfigurationManager.ConnectionStrings["oficinaSqlServer"].ConnectionString;

        public void Apagar(int id)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string nomeProcedure = "CorApagar";
                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                   // comando.Parameters.AddWithValue("@nome", cor.Nome);

                    comando.ExecuteNonQuery();
                }
            }

        }

        public void Atualizar(Cor cor)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string nomeProcedure = "CorAtualizar";
                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", cor.Id);
                    comando.Parameters.AddWithValue("@nome", cor.Nome);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Cor> Ler()
        {
            var cores = new List<Cor>();

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string instrucao = "Select id, nome from Cor order by Nome";

                using (var comando = new SqlCommand(instrucao, conexao))
                {
                    using (var registros = comando.ExecuteReader())
                    {
                        while (registros.Read())
                        {
                            cores.Add(Mapear(registros));
                        }
                    }
                }
                //conexao.Close();

            }
            return cores;
        }

        private Cor Mapear(SqlDataReader registro)
        {
            var cor = new Cor();

            cor.Id = Convert.ToInt32(registro["Id"]);
            cor.Nome = Convert.ToString(registro[nameof(cor.Nome)]); // Automapper - componente


            return cor;
        }

        public Cor Ler(int id)
        {
            Cor cor = null;

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string nomeProcedure = "CorLer";

                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    using (var registros = comando.ExecuteReader())
                    {
                        if (registros.Read())
                        {
                            cor = Mapear(registros);
                        }
                    }
                }
                //conexao.Close();

            }

            return cor;
        }

        public int Salvar(Cor cor)
        {

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string nomeProcedure = "CorSalvar";
                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nome", cor.Nome);

                    return (int)comando.ExecuteScalar();
                }
                //conexao.Close();

            }

        }
    }
}
