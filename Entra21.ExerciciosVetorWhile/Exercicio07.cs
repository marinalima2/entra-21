using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetorWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {

            double[] alturas = new double[4];
            double menorAltura = 0;


            for (int i = 0; i <4; i++)
            {

                Console.WriteLine("Informe a altura: ");
                alturas[i] = Convert.ToDouble(Console.ReadLine());

            }

            for(int i = 0; i <4; i++)
            {

                if (alturas[i] < menorAltura)
                {

                    menorAltura = alturas[i];

                }
            }
        Console.WriteLine("A menor altura é: "+menorAltura);

        }

    }
}


           
        
