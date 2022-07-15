﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.DataBase
{
    internal class Conexao
    {

        public SqlConnection Conectar()
        {
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

            return conexao;

        }


    }
}
