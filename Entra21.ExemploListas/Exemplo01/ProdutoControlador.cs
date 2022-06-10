namespace Entra21.ExemploListas.Exemplo01
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            int codigo = 0;
            //Repete enquanto o código não for o menu sair 
            while (codigo != 6)
            {
                Console.Clear();
                //Apresenta menu e solicita código 
                codigo = ApresentarSolicitarMenu();
                Console.Clear();
                if (codigo == 1)
                {
                    //Menu escolhido para listar produtos 
                    ApresentarProdutos();
                }
                else if (codigo == 2)
                {
                    //Menu escolhido para cadatrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {   //Menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                else if (codigo == 5)
                {
                    ApresentarProduto();
                }
                Console.WriteLine("\n\n Aperte alguma tecla para continuar: ");
                Console.ReadKey();

            }
        }


        private void ApresentarProduto()
        {
            ApresentarProduto();

            Console.WriteLine("Digite o código do produto a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);

            //Verfica se o produto não está cadastrado na lita de produtos
            if(produto == null)
            {
                Console.WriteLine("Produto não está cadastrado");

                return;
            }
            Console.Clear();
            Console.WriteLine(@"Código: " + produto.Codigo +
                "\nnome: " + produto.Nome + "\n" + "Preço unitário: " + produto.PrecoUnitario + "\n" +
               "Quantidade: " + produto.Quantidade + "\n " + "Total: " + produto.CalcularPrecoTotal());
        }
        private void Apagar()
        {
            ApresentarProdutos();

            Console.WriteLine("Digite o código do produto para apagar");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = produtoServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro removido com sucesso" 
                :"Nenhum produto cadastrado com código informado");

        }

        private void Editar()
        {
            ApresentarProdutos();

            Console.WriteLine("Código produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Preço Unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localização disponiveis:
- Armazem 
- Area Venda
- Loja");
            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == false)
            {
                Console.WriteLine("Código digitado não existe");
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso");
            }
        }
        public int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"  MENU
1- listar todos
2- Cadastrar
3- Editar 
4- Apagar 
5- Apresentar produto desejado 
6 - sair");

            int codigo = SolicitarCodigo();
            return codigo;

        }
        private int SolicitarCodigo()
        {
            int codigo = 0;
            //Continua solicitando o código até q   ue seja um código entre 1 e 6
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.WriteLine("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Digite u valor válido");
                }
            }
            return codigo;
        }
        private void Cadastrar()
        {
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preço Unitário: ");
            var precoUnitario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(@"Localizações disponiveis:
- Armazem 
- Area Venda 
- Loja");
            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);
            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }
        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }

        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado");
                //Para execução deste método
                return;
            }

            Console.WriteLine("Lista de produtos: ");

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];
                Console.WriteLine(
                    "Nome: " + produtoAtual.Nome + "\nCódigo: " + produtoAtual.Codigo + "\n");
            }
        }
    }
}