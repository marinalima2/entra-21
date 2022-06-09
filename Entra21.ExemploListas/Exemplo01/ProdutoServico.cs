

namespace Entra21.ExemploListas.Exemplo01
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
        //Encapsulamento + tipoRetorno + nomeMetodo + (parametros)
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade){

            //Instanciar um objeto na classe;
            Produto produto = new Produto();
            
            //Atribuir valor para as propriedades com os dados passados com o parametro;
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }

        public void Editar(){}

        public void Apagar(){}

        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        public Produto ObterPorCodigo()
        {
            return null;
        }

    }
}
