using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio08
    {
        public void Executar() {

            Console.WriteLine("Informe um número: ");
            int numeroInformado = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i  < 1000; i++) {

               Console.WriteLine(numeroInformado* i);
               
            
            }
        }
    }
}
