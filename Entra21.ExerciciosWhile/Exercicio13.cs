using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        public void Executar() {

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Sexo: ");
            string sexo = Console.ReadLine();


            Console.WriteLine("Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantidade de gols marcados: ");
            int gols = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade de cartões amarelos recebidos: ");
            int cartaoAmarelo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade de cartões vermelhos recebidos: ");
            int cartaoVermelho = Convert.ToInt32(Console.ReadLine());

        }
    }
}
