using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo03
    {
        public void Executar()
        {
           int indice = 0;
            int quantidadeDesejada = 0;
            while (indice == quantidadeDesejada)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();

                indice = indice + 1;
            }
        }
    }
}
