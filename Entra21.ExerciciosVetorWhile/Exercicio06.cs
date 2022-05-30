using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetorWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {

            int[] idades = new int[9];
            int maiorIdade = 0;

            for (int i = 0; i <9; i++)
            {
                Console.WriteLine("Informe a idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.Clear();
            for (int i = 0; i <9; i++)
            {

                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];

                }
            }
            Console.WriteLine("A maior idade é: "+ maiorIdade);
        }

    }
}
