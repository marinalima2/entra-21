using System;

namespace Entra21.BancoDados01.Ado.Net.Models
{
    public class Editora
    {
        // O que é Get set sera apresentado posteriormente
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Faturamento { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Apelido { get; set; }
    }
}
