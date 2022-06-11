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



        }

    private void ApresentarTrianguloPorCodigo()
    {
        ApresentarTrianguloPorCodigo();

        Console.WriteLine("Digite o código do triangulo a ser detalhado: ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        var triangulo = TrianguloServico.ObterPorCodigo(codigo);

        if (triangulo == null)
        {

            

        }




    }

    }

