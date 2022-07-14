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



    }
}
