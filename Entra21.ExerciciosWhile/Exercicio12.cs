using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio12
    {
        public void Executar()
        {     

            int quantidadeProdutos = 0;
            double valorTotal = 0;
            int quantidadeBolos = 0;
            int quantidadeBomba = 0;
            int quantidadeSanduiches = 0;
            int quantidadePizzas = 0;
            int escolhaPedido = 0;

            while (escolhaPedido != 16)
            {
               
                Console.WriteLine(@"
            
         _____________________________________________________________________
        | Código  | Tipo        | Nome                      | Valor           |      
        |_________|_____________|___________________________|_________________|
        |1        | BOLO        | Bolo Brigadeiro           | R$ 29,50        |
        |2        | BOLO        | Bolo Nega Maluca          | R$ 19,33        |
        |3        | DOCES       | Bomba de Creme            | R$ 17,71        |
        |4        | DOCES       | Bomba de Morango          | R$ 4,82         |
        |5        | SANDUÍCHES  | Provolone com salame      | R$ 19,70        |
        |6        | SANDUÍCHES  | Vegetariano de berinjela  | R$ 28,22        |
        |7        | PIZZAS      | Calabresa                 | R$ 8,98         |
        |8        | PIZZAS      | Portuguesa                | R$ 27,50        |
        |16       | SAIR        |                           |                 |
        |_________|_____________|___________________________|_________________|");


                Console.WriteLine("\nEscolha seu pedido: ");
               escolhaPedido = Convert.ToInt32(Console.ReadLine());

                if (escolhaPedido == 1)
                {
                    quantidadeBolos = quantidadeBolos + 1;
                    double boloUm = 29.50;
                    valorTotal = valorTotal + boloUm;
                    quantidadeProdutos = quantidadeProdutos + 1;
                }

                if (escolhaPedido == 2)
                {
                    quantidadeBolos = quantidadeBolos + 1;
                    double boloDois = 19.33;
                    valorTotal = valorTotal + boloDois;
                    quantidadeProdutos = quantidadeProdutos + 1;
                }

                if (escolhaPedido == 3)
                {
                    quantidadeBomba = quantidadeBomba + 1;
                    double bombaUm = 17.71;
                    valorTotal = valorTotal + bombaUm;
                    quantidadeProdutos = quantidadeProdutos + 1;

                }

                if (escolhaPedido == 4)
                {
                    quantidadeBomba = quantidadeBomba + 1;
                    double bombaDois = 4.82;
                    valorTotal = valorTotal + bombaDois;
                    quantidadeProdutos = quantidadeProdutos + 1;
                }

                if (escolhaPedido == 5)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    double sanduicheUm = 19.70;
                    valorTotal = valorTotal + sanduicheUm;
                    quantidadeProdutos = quantidadeProdutos + 1;
                }

                if (escolhaPedido == 6)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    double sanduicheDois = 28.22;
                    valorTotal = valorTotal + sanduicheDois;
                    quantidadeProdutos = quantidadeProdutos + 1;

                }

                if (escolhaPedido == 7)
                {
                    quantidadePizzas = quantidadePizzas + 1;
                    double pizzaUm = 8.98;
                    valorTotal = valorTotal + pizzaUm;
                    quantidadeProdutos = quantidadeProdutos + 1;

                }

                if (escolhaPedido == 8)
                {
                    quantidadePizzas = quantidadePizzas + 1;
                    double pizzaDois = 27.50;
                    valorTotal = valorTotal + pizzaDois;
                    quantidadeProdutos = quantidadeProdutos + 1;

                }
               
            }
            Console.WriteLine("O valor total é: " + valorTotal.ToString("F"));
            Console.WriteLine("A quantidade de produtos é: " + quantidadeProdutos);
            Console.WriteLine("A quantidade de bolos é: " + quantidadeBolos);
            Console.WriteLine("A quantidade de doces é: " + quantidadeBomba);
            Console.WriteLine(" A quantidade de sanduíches é: " + quantidadeSanduiches);
            Console.WriteLine("A quantidade de pizzas é: " + quantidadePizzas);

        }
    }
}
