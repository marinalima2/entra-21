using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double peso = 0;
            int quantidadePessoas = 0;

            while (peso >= 0 && peso < 300.00)
            {
                Console.WriteLine("Informe o seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                quantidadePessoas = quantidadePessoas + 1;

            }
            Console.WriteLine("Quantidade de pesssoas que informaram o peso :" + quantidadePessoas);
        } 

    }
}
