namespace Entra21.ExemploListas.Exemplo01
{
    public class Produto
    {
        public int Codigo;
        public string Nome;
        public double PrecoUnitario;
        public int Quantidade;
        public ProdutoLocalizacao Localizacao;

            public double CalcularPrecoTotal()
        {

            var preco = Quantidade * PrecoUnitario;
            return preco;

        }
    }
}
