using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetorWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double[] pesos = new double[5];
            double somaTotal = 0;
            double mediaPesos = 0;

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine("Informe o peso: ");
                pesos[i] = Convert.ToDouble(Console.ReadLine());
                somaTotal= somaTotal+pesos[i];
                mediaPesos = somaTotal/5;

            }

            Console.Clear();

            //Apresentar Dados

            Console.WriteLine("A soma dos pesos é: "+ somaTotal);
            Console.WriteLine("A média de pesos é: "+ mediaPesos);


        }
    }
}