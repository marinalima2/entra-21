using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio10
    {
        public void Executar()
        {

            Console.WriteLine("Informe um número: ");
            var numeroInformado = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i <= 50; i++)
            {

                if (numeroInformado % 2 == 0)
                {
             
                    
                        Console.WriteLine(numeroInformado * i);
                    
                }
                else if (numeroInformado % 2 != 0)
                {
                    Console.WriteLine(numeroInformado * i);
                }
            }
        }
    }
}
