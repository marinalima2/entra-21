using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;
using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.Servicos
{
    //Dois pontos seguidos de uma interface, quer dizer que a classe será obrigada a implementar 
    // o métodos(contratos) estabelecidos na interface

    // serciço, repositório tem interface

    internal class TipoPersonagemServico : ITipoPersonagemServico
    {

        public void Cadastrar(Models.TipoPersonagem tipoPersonagem)
        {
            //Será descrito a implementação do contrato definido na interface

            var conexao = new Conexao().Conectar();


            //Instanciando um objeto da classe SqlConnection,
            // que permite fazer selects, inserts, updates, deletes, etc
            SqlConnection conexao = new SqlConnection();

            //String quw contém o caminho para o banco de dados 
            //o que permitirá conectar ao banco de dados 
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Server\c#-noturno\marina.lima\Desktop\ExemploBancoDados01AdoNet.mdf;Integrated Security=True;Connect Timeout=30";


            //Definir o caminho da conexão para o sqlConnection
            conexao.ConnectionString = connectionString;

            //Abrir conexao para o banco de dados 
            conexao.Open();


            //Criar o comando para executar no banco de dados 

            SqlCommand comando = conexao.CreateCommand();

            //Especificado o comando que será executado 

            comando.CommandText = "INSERT INTO tipos_personagens (tipo) VALUES ('" + 
                tipoPersonagem.Tipo + "')";

            //Executando o comando de insert na tabela de tipos_personagens 

            comando.ExecuteNonQuery();

            conexao.Close();

        }

        public List<TipoPersonagem> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = 'SELECT id, tipo FROM tipos_personagens';

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var tiposPersonagens = new List<TipoPersonagem>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {

                var linha = tabelaEmMemoria.Rows[1];


                var tipoPersonagens = new TipoPersonagem();
                TipoPersonagem.id = Convert.ToInt32(linha["id"].ToString());

                tipoPersonagem.Tipo = linha["tipo"].ToString();

                tiposPersonagens.add(tipoPersonagem);
            }

            comando.Connection.Close();

            return tiposPersonagens;
        }



    }
}
