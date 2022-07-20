namespace Entra21.ExercicioListaObjetos.Exercicio01
{
    internal class TrianguloControlador
    {

        private TrianguloServico trianguloServico = new TrianguloServico();

        //public void GerenciarMenu()
        //{
        //    int codigo = 0;
        //    while(codigo != 4)
        //    {
               

        //   }
        //
        //  


        public void Adicionar()
        {

            Console.WriteLine("Lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());    

            Console.WriteLine("Lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());    

            TrianguloServico.Adicionar(lado1, lado2, lado3);



        }


    private void ApresentarTrianguloPorCodigo()
    {
        ApresentarTrianguloPorCodigo();

        Console.WriteLine("Digite o código do triangulo a ser detalhado: ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        var triangulo = trianguloServico.ObterPorCodigo(codigo);

        if (triangulo == null)
        {

            Console.WriteLine("Triangulo não está cadastrado");
            return;
        }
        Console.Clear();
        Console.WriteLine(@"Código: " + triangulo.Codigo);
    }

        private void Apagar()
        {
            ApresentarTrianguloPorCodigo();
           Console.WriteLine("Digite o código do triangulo para apagar");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var trianguloApagado = trianguloServico.Apagar(codigo);
            Console.WriteLine(trianguloApagado == true
                ? "Triângulo removido com sucesso" 
                :"Nenhum triangulo cadastrado com código informado");
        }

        private void Editar()
        {
            ApresentarTrianguloPorCodigo();

            Console.WriteLine("Informe o código: ");
            var codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Informe o lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());    

            var alterar = trianguloServico.Editar(codigo, lado1, lado2, lado3);
             if (alterar == false)
            {
                Console.WriteLine("Código digitado não existe");
            }
            else
            {
                Console.WriteLine("triangulo alterado com sucesso");
            }
        }

       private void MostrarTodos()
        {
            var triangulos = trianguloServico.ObterTodos();

              if (triangulos.Count == 0)
            {
                Console.WriteLine("Nenhum triangulo cadastrado");
                return;
            }

            Console.WriteLine("Lista de triangulos: ");

            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];
                Console.WriteLine(triangulos);
            }
        }
    }

    

        private TrianguloServico trianguloServico = new TrianguloServico();

        //public void GerenciarMenu()
        //{
        //    int codigo = 0;
        //    while(codigo != 4)
        //    {
               

        //   }
        //
        //  


        public void Adicionar()
        {

            Console.WriteLine("Lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lado 2: ")
            var lado2 = Convert.ToInt32(Console.ReadLine());    

            Console.WriteLine("Lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());    

            trianguloServico.Adicionar(lado1, lado2, lado3);



        }


    private void ApresentarTrianguloPorCodigo()
    {
        ApresentarTrianguloPorCodigo();

        Console.WriteLine("Digite o código do triangulo a ser detalhado: ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        var triangulo = TrianguloServico.ObterPorCodigo(codigo);

        if (triangulo == null)
        {

            Console.WriteLine("Triangulo não está cadastrado");
            return;
        }
        Console.Clear();
        Console.WriteLine(@"Código: " + triangulo.Codigo);
    }

        private void Apagar()
        {
            ApresentarTrianguloPorCodigo();
           Console.WriteLine("Digite o código do triangulo para apagar");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var trianguloApagado = trianguloServico.Apagar(codigo);
            Console.WriteLine(trianguloApagado == true
                ? "Triângulo removido com sucesso" 
                :"Nenhum triangulo cadastrado com código informado");
        }

        private void Editar()
        {
            ApresentarTrianguloPorCodigo();

            Console.WriteLine("Informe o código: ");
            var codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Informe o lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());    

            var alterar = trianguloServico.Editar(codigo, lado1, lado2, lado3);
             if (alterar == false)
            {
                Console.WriteLine("Código digitado não existe");
            }
            else
            {
                Console.WriteLine("triangulo alterado com sucesso");
            }
        }

       private void MostrarTodos()
        {
            var triangulos = trianguloServico.ObterTodos();

              if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum triangulo cadastrado");
                return;
            }

            Console.WriteLine("Lista de triangulos: ");

            for (var i = 0; i < produtos.Count; i++)
            {
                var trianguloAtual = triangulos[i];
                Console.WriteLine(triangulos);
            }
        }
     }

    }

