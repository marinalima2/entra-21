namespace Entra21.ExemploListas.Exemplo01
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
        //Armazenar o código do próximo produto
        private int codigoAtual = 1;

        //Encapsulamento + tipoRetorno + nomeMetodo + (parametros)
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //Instanciar um objeto na classe;
            Produto produto = new Produto();
            
            //Atribuir valor para as propriedades com os dados passados com o parametro;
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            //Adicionar 1 no código atual para quando criar um novo produto o 
            //produto conter outro código
            codigoAtual = codigoAtual + 1;

            //Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);

        }

        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            if (produtoParaAlterar == null)
            {
                //Retorna falso porque não existe o produto com o código dos parametros 
                return false;
            }

            //Atualiza as´propriedades (campos) do produto desejado

            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;
            return true;
        }

        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                //Resgatando uma lista de tipos primitivos
                //int numero = numero[i]
                //Resgatando uma lista de objetos

                Produto produto = produtos[i];
                if (produto.Codigo == codigo)
                {
                    //Posso remover com o indice do objeto desejado 
                    // produtos.RemoveAt(i);

                    //Posso remover com o objeto desejado 
                    produtos.Remove(produto);
                    //Retorna true porque o produto com o código desejado foi removido da lista
                    return true;
                }
            }
            //Retorna falso porque não foi encontrado produto com o código desejado, ou seja
            //nenhum elemento foi removido da lista
            return false;
        }
        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo(int codigo)
        {
            //Percorrer todos os elementos para encontrar o produto 
            // filtrando por código
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obter o produto da lista de produtos em determinado indice 
                var produtoAtual = produtos[i];

                //Verifica se produto atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    //Retorna o produto encontrado 
                    return produtoAtual;
                }

                //Retorna null, caso não encontre um produto com o código passado como parametro 
            }
            return null;
        }

        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;
            for(int i = 0;i < produtos.Count; i++)
            {
                Produto produto = produtos[i];
                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    menorPrecoUnitario = produto.PrecoUnitario;
                    produtoMenorPrecoUnitario = produto;

                }
            }
            return produtoMenorPrecoUnitario; 

        }

        public List <double> ObterTodosPrecos()
        {
            //Criar uma lista de preços totais
            var precos = new List<double>();

            //Percorre todos os produtos
            for(int i = 0; i < produtos.Count; i++)
            {
                //Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                //Adiciona o preço total na lista de preços
                precos.Add(produto.CalcularPrecoTotal());
            }   
            return precos;
        }
        
        public List<double>ObterPrecosTotaisFiltrandoPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            //Criar uma lista de preços totais
            var precos = new List <double>();

            //Percorre todos os produtos
            for(var i = 0; i < produtos.Count; i++)
            {
                //Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                //Verifica se a localização do produto atual é a localização passada no parametro
               if (produto.Localizacao == localizacao)
                {
                    // Adiciona o preço total do produto atual que foi filtrado por localização
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public List<double> ObterPrecosTotaisDoArmazem()
        {
            //Criar uma lista de preços totais 
            var precos = new List<double>();

            //Percorre todos os produtos 
            for (int i =0; i < produtos.Count; i++)
            {
                //Obtém o produto atual na lista de produtos
                var produto = produtos[i];

                //Verifica se a localização do produto atual é armazem
                if(produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    //Adiciona o preço total do produto atual que foi filtrado por armazem 
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
             return precos;
        }

        public double ObterMediaPrecosTotais()
        {
            var somaPrecosTotais = 0.0;

            //Percorre todos os produtos 
            for(int i = 0; i < produtos.Count; i++)
            {
                //Obtém o produto atual da lista de produtos 
                var produto = produtos[i];
            
                //Adiciona o preço total do produto na variavel soma de preços totais
            somaPrecosTotais += produto.CalcularPrecoTotal();
            }
            var media = somaPrecosTotais/produtos.Count;
            return media;

        }
    }
}