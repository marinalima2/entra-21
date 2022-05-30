using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetorWhile
{
    internal class Exercicio03
    {

        public void Executar()
        {
            //Coletar informações

            string[] nomeProdutos = new string[7];
            double[] precos = new double[7];
            double somaPrecos = 0;
            for (int i = 0; i <7; i++)
            {
                Console.WriteLine("Informe o nome do produto: ");

                nomeProdutos[i] = Console.ReadLine();

                Console.WriteLine("Informe o valor do produto: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            // Apresentar os Dados
            for (int i = 0; i <7; i++)
            {
                Console.WriteLine(nomeProdutos[i]);
                Console.WriteLine(precos[i]);
            }
        }
    }
}
