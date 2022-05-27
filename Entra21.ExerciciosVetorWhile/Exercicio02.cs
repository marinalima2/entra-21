using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetorWhile
{
    internal class Exercicio02
    {
        public void Executar()
        {

            string[] nomes = new string[3];

            int indice = 0;

            while (indice < nomes.Length)
            {
                Console.WriteLine("Informe um nome: ");
                nomes[indice] = Console.ReadLine();
                indice++;
            }


            Console.Clear();
             
            indice = 0;
            while (indice < nomes.Length)
            {
                Console.WriteLine(nomes[indice]);
                indice++;
            }
            



        }
    }
}
