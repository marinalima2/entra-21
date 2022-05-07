using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {     public void Executar()
        {

            Console.WriteLine("Informe a quantidade desejada:");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());
            int indice = quantidadeDesejada;
            int anoCarro = 0;
            double valorCarro = 0;
            string modelo = "";
            double somaValorCarros = 0;
            int somaAnoCarros = 0;

            while (indice == quantidadeDesejada)
            {
                Console.WriteLine("Informe o modelo do carro: ");
                modelo = Console.ReadLine();
                modelo = modelo + 1;

                Console.WriteLine("Informe o valor do carro: ");
                valorCarro = Convert.ToDouble(Console.ReadLine());
                somaValorCarros = valorCarro+1;

                Console.WriteLine("Informe o ano do carro: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());
                somaAnoCarros = anoCarro+1;

                
            }

            int mediaAnoCarros = somaAnoCarros / quantidadeDesejada;
            Console.WriteLine("A média de ano dos carros é :" + mediaAnoCarros);

            double mediaValorCarros = valorCarro / quantidadeDesejada;
            Console.WriteLine("A média do valor dos carros é:" + mediaValorCarros);
        
        
        
        }

    }
}
