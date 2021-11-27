using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_gastos
{
    class BancoDeDados
    {
        

        string produtoBD = "";                  //Nome do produto
        double valorDoProdutoBD = 0.0;          //Valor do Produto individual
        int quantidadeBD = 0;                   //Quantidade de produtos
        double valorTotalDoProdutoBD = 0.0;     //Valor total do produto

        public BancoDeDados(string produtoBD, double valorDoProdutoBD, int quantidadeBD, double valorTotalDoProdutoBD)
        {
            this.produtoBD = produtoBD;
            this.valorDoProdutoBD = valorDoProdutoBD;
            this.quantidadeBD = quantidadeBD;
            this.valorTotalDoProdutoBD = valorTotalDoProdutoBD;
        }

        public BancoDeDados()
        {
        }
        /*using Microsoft.Data.SqlClient;
        using System;
        using System.Collections.Generic;
        using System.Data;
        using System.Text;

        namespace ProjetoEsportesInfra
        {
            public class ConexaoDB : IDisposable
            {

                private string _outputStatus;
                private string _outputMessage;

                public string outputStatus
                {
                    get => _outputStatus;
                    set
                    {
                        _outputStatus = value;
                    }
                }

                public string outputMessage
                {
                    get => _outputMessage;
                    set
                    {
                        _outputMessage = value;
                    }
                }


                private void ExecuteNonQuery(string status, string message)
                {
                    outputMessage = status;
                    outputMessage = message;

                }

                public DataTable TestConexao(string connectionString, string query)
                {
                    DataTable dt = new DataTable();

                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                    if (query == "")
                    {
                        //TesteConexao
                        query = @"SELECT * FROM tb_Posicao with(nolock)";
                    }

                    if (connectionString == "")
                    {

                        //Data Source=(localdb)\Rian;Initial Catalog=CAMPEONATO_ESPORTES;Integrated Security=True
                        //TesteConexao
                        builder.DataSource = "(localdb)\\Rian";
                        builder.IntegratedSecurity = true;
                        builder.InitialCatalog = "CAMPEONATO_ESPORTES";
                    }
                    using (var connection = new SqlConnection(builder.ConnectionString))
                    {

                        using (var command = new SqlCommand(query, connection))
                        {

                            connection.Open();

                            var reader = command.ExecuteReader();


                            dt.Load(reader);


                        }

                        connection.Dispose();
                    }

                    return dt;

                }
                public void Dispose()
                {
                    //Fecha Conexão
                }

                public void Insert(SqlCommand cmd, SqlConnection connection)
                {
                    try
                    {
                        connection.Open();

                        cmd.CommandType = CommandType.StoredProcedure;

                        var execute = cmd.ExecuteNonQuery();

                        ExecuteNonQuery(cmd.Parameters["@Status"].Value.ToString(), cmd.Parameters["@Message"].Value.ToString());

                        connection.Dispose();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                    }

                }

                public void Delete(SqlCommand cmd)
                {
                    try
                    {
                        ExecuteNonQuery("", "");
                    }
                    catch (Exception ex)
                    {

                    }

                }

                public void Update(SqlCommand cmd)
                {
                    try
                    {
                        ExecuteNonQuery("", "");
                    }
                    catch (Exception ex)
                    {

                    }

                }

                public DataSet ObterDataSet(SqlCommand cmd)
                {

                    DataSet ds = new DataSet();

                    return ds;
                }

                public SqlDataReader ObterLista(SqlCommand cmd)
                {

                    var reader = cmd.ExecuteReader();



                    return reader;
                }


            }
        }*/

        public string Testar()
        {
            string conexao = "Desconectado";
               
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-L1M5MTD;Initial Catalog=TesteRian;
                                    User ID=Leonardo Fernandes;Password=123456789";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                Console.WriteLine("BD funcoinando"); //texto só para teste
                cnn.Close();
                conexao = "Conectado";
            }
            catch (SqlException erro)
            {
                Console.WriteLine("BD com erro de abertura" + "\n\nMensagem de erro:\n"); //texto só para teste
                Console.WriteLine(erro + "\n\n"); //texto só para teste
            }

            return conexao;
        }

        public string Consultar()
        {
            string consulta = "Sem valor";

            //Fazer consulta

            return consulta;
        }

        public bool Enviar()
        {
            bool envio = false;

            //Fazer envio

            return envio;
        }

        /*public string FecharBD()
        {
            string fechado = "Não fechado";

            //Fazer fechamento do DB

            return fechado;
        }*/
    }
}
