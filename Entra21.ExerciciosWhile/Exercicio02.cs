using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string nome = "";

            while(nome != "FIM".ToLower())
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();
            }


        }
    }
}
