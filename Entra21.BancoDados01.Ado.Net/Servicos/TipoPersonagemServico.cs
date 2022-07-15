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
        public void Apagar(int id)
        {
            //Conectar com o BD
            var conexao = new Conexao().Conectar();

            //Criar comando para executar o delete
            var comando = conexao.CreateCommand();


            //Definindo o comando para apagar o registro
            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = " + id;

            //executando o comando para apagar os registros 
            comando.ExecuteNonQuery();

            //Fechar conexão com o BD
            comando.Connection.Close();

        }

        public void Cadastrar(Models.TipoPersonagem tipoPersonagem)
        {
            //Será descrito a implementação do contrato definido na interface

            var conexao = new Conexao().Conectar();

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

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var tiposPersonagens = new List<TipoPersonagem>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {

                var linha = tabelaEmMemoria.Rows[i];


                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());

                tipoPersonagem.Tipo = linha["tipo"].ToString();

                tiposPersonagens.Add(tipoPersonagem);
            }

            comando.Connection.Close();

            return tiposPersonagens;
        }



    }
}
