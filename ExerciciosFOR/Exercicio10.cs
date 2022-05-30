using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFOR
{
    internal class Exercicio10
    {
        public void Executar()
        {

            Console.WriteLine("Insira um número menor que 50");
            var numeroDigitado = Convert.ToInt32(Console.ReadLine());



            for (var i = numeroDigitado; i < 50; i++)
            {
                Console.WriteLine(numeroDigitado);
            }
            
        }

    }

}




