using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int indice = 0;

            while (indice < 13)
            {
                Console.WriteLine("Nome da peça: ");
                string nomePeca = Console.ReadLine();
                Console.WriteLine("Preço da peça: ");
                double precoPeca = Convert.ToDouble(Console.ReadLine());

                indice = indice + 1;

            }
        }
    }
}

