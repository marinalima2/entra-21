using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetorWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int[] numeros = new int[5];

            int indice = 0;
            int soma = 0;

            while (indice < numeros.Length)
            {
                Console.WriteLine("Informe um número");
                numeros[indice] = Convert.ToInt32(Console.ReadLine());
                soma = soma + numeros[indice];
                indice++;
            }
            Console.WriteLine("soma:" + soma);
        }
    }
}

