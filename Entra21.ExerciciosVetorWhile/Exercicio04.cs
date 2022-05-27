using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetorWhile
{
    internal class Exercicio04
    {
        public void Executar()
        {

            double[] disciplina = new double[4];
            double somaNotas = 0;
            double media = 0;

            //Coletar Dados

            for (int i = 0; i <4; i++)
            {
                Console.WriteLine("Informe uma nota:");
                disciplina[i] = Convert.ToDouble(Console.ReadLine());
                somaNotas = somaNotas + disciplina[i];
                media = somaNotas/4;

            }

            Console.Clear();

            // Apresentar Dados 

            Console.WriteLine("Sua média é: "+ media);

        }
    }
}
