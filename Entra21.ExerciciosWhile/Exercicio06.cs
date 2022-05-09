using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {

            double valorTotal = 0;
            string nomeProduto = "";

            while (nomeProduto != "sair")
            {
                Console.WriteLine("Informe o nome do produto: ");
                nomeProduto = Console.ReadLine().ToLower();
                if (nomeProduto != "sair")
                {

                    Console.WriteLine("Informe o valor do produto: ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade de produtos: ");
                    int quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                    valorTotal = valorTotal + valorProduto;
                }   
               
            }
            double desconto = (valorTotal * 5) / 100;
            double valorTotalDesconto = valorTotal - desconto;
            Console.WriteLine("O valor total é :" + valorTotalDesconto);

        }
    }
}
