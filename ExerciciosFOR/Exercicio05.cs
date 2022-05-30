using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFOR
{
    internal class Exercicio05
    {
        public void Executar()
        {

            Console.WriteLine("Informe a quantidade de carros para cadastro: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine);
            double mediaValor = 0;
            double mediaAno = 0;
            var quantidadeCarrosG = 0;
            var quantidadeCarrosA = 0;

            for (var i = 0; i == quantidadeCarros; i++)
            {
                Console.WriteLine("Informe o modelo do carro: ");
                var modeloCarro = Console.ReadLine().ToLower();

                Console.WriteLine("Informe o valor do carro: ");
                var valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o ano do carro: ");
                var anoCarro = Convert.ToInt32(Console.ReadLine());

              
                if (modeloCarro.StartsWith("G"))
                {
                    quantidadeCarrosG = quantidadeCarrosG + 1;
                }
                else if (modeloCarro.StartsWith("A"))
                {

                    quantidadeCarrosA = quantidadeCarrosA + 1;
                }

               mediaValor = valorCarro / quantidadeCarros;
               mediaAno = anoCarro / quantidadeCarros;
            }
            Console.WriteLine(@"
                Quantidade de carros com G: " + quantidadeCarrosG
                + "Quantidade de carros com A: " + quantidadeCarrosA +
                "Média de valor do carros: " + mediaValor+
                "Média de ano dos carros:" + mediaAno);
        }
    }
}
