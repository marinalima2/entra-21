using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class ExercicioLivro
    {
        public void Executar()
        {
           Livro livro = new Livro();
           Console.WriteLine("Informe o nome do livro: ");
           livro.Titulo = Console.ReadLine();
           Console.WriteLine("Informe o autor: ");
           livro.Autor = Console.ReadLine();
           Console.WriteLine("Informe o código ISBN: ");
           livro.CodigoIsbn = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Informe o idioma original: ");
           livro.IdiomaOriginal = Console.ReadLine();
           Console.WriteLine("Informe a data de lançamento: ");
           livro.DataLancamento = Convert.ToDateTime(Console.ReadLine());
           Console.WriteLine("Informe a quantidade de páginas: ");
           livro.QuantidadePaginas = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Informe a quantidade de páginas lidas: ");
           livro.QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Informe quantas releituras: ");
           livro.Releitura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Título e autor: " + livro.ObterTituloAutor());


        }



    }
}
