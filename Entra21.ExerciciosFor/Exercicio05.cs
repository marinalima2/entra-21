using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio05
    {
        public void Executar()
        {

            Console.WriteLine("Informe a quantidade de carros para cadastro: ");
            var quantidadeDesejada = Convert.ToInt32(Console.ReadLine());
            int somaAnos = 0;
            var somaValores = 0.0;
            var  quantidadeCarrosG = 0;
            var quantidadeCarrosA = 0;
            var mediaAnos = 0.0;
            var mediaValores = 0.0;


            for (var i = 0; i < quantidadeDesejada; i++ )
            {

                Console.WriteLine("Informe o modelo do carro: ");
                var modeloCarro = Console.ReadLine();
                if (modeloCarro.StartsWith("G"))
                {
                    quantidadeCarrosG = quantidadeCarrosG + 1;
                }
                else if (modeloCarro.StartsWith("A")) {
                    quantidadeCarrosA = quantidadeCarrosA + 1;
                }

                Console.WriteLine("Informe o valor do carro: ");
                var valorCarro = Convert.ToDouble(Console.ReadLine());
                somaValores = somaValores + valorCarro;  

                Console.WriteLine("Informe o ano do carro: ");
                var anoCarro = Convert.ToInt32(Console.ReadLine());
                somaAnos = somaAnos + anoCarro;

                mediaAnos = somaAnos / quantidadeDesejada;
                mediaValores = somaValores / quantidadeDesejada;
                
            }
             Console.WriteLine(@" A média de ano dos carros é:" + mediaAnos +
                 "\nCarros que começam com a letra A:" + quantidadeCarrosA+
                 "\nCarros que começam com a letra G: "+quantidadeCarrosG+
                 "\nMédia de valor dos carros: "+ mediaValores);

            

        }
    }
}
