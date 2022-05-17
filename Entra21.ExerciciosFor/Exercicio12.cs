using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio12
    {
        public void Executar()
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

            Console.WriteLine("\nInforme a quantidade de pedidos desejada: ");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

            var quantidadeBolos = 0;
            var quantidadeDoces = 0;
            var quantidadeSanduiches = 0;
            var quantidadePizzas = 0;
            var precoProdutos = 0.0;
            var somaTotal = 0.0;
            var media = 0.0;

            for (var i = 0; i < quantidadeDesejada; i++)
            {
              

                Console.WriteLine("\nInforme a opção desejada: ");
               var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                if (opcaoDesejada == 1)
                {

                    quantidadeBolos = quantidadeBolos + 1;
                    var preco1 = 29.50;
                    somaTotal = somaTotal + preco1;

                }
                else if (opcaoDesejada == 2)
                {

                    quantidadeBolos = quantidadeBolos + 1;
                    var preco2 = 19.33;
                    somaTotal = somaTotal + preco2;

                }
                else if (opcaoDesejada == 3)
                {

                    quantidadeDoces = quantidadeDoces + 1;
                    var preco3 = 17.71;
                    somaTotal = somaTotal + preco3;

                }
                else if (opcaoDesejada == 4)
                {
                    quantidadeDoces = quantidadeDoces + 1;
                    var preco4 = 4.82;
                    somaTotal = somaTotal + preco4;
                }
                else if (opcaoDesejada == 5)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    var preco5 = 19.70;
                    somaTotal = somaTotal + preco5;

                }
                else if (opcaoDesejada == 6)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    var preco6 = 28.22;
                    somaTotal = somaTotal + preco6;

                }
                else if (opcaoDesejada == 7)
                {
                    quantidadePizzas = quantidadePizzas + 1;
                    var preco7 = 8.98;
                    somaTotal = somaTotal + preco7;

                }
                else if (opcaoDesejada == 8)
                {
                    quantidadePizzas = quantidadePizzas + 1;
                    var preco8 = 27.50;
                    somaTotal = somaTotal + preco8;

                }

                media = somaTotal / quantidadeDesejada;

                Console.WriteLine(@"Quantidade de bolos escolhidos : " + quantidadeBolos +
                    "\nQuantidade de doces escolhidos: " + quantidadeDoces +
                    "\nQuantidade de sanduíches escolhidos: " + quantidadeSanduiches +
                    "\nQuantidade de pizzas escolhidas: " + quantidadePizzas +
                    "\nMédia dos produtos escolhidos: " + media);

            }
        }
    }
}
