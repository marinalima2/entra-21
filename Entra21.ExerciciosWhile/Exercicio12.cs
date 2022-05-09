using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio12
    {
        public void Executar() {

            //. A padaria do joão necessita armazenar os pedidos dos seus clientes, cada cliente
            //poderá realizar quantos pedidos desejar, porém para que o cliente possa solicitar
            // estes produtos o cardápio deve ser apresentado para ele.
            //Ao final de o cliente solicitar os produtos, deve-se apresentar o total dos pedidos e a
            //quantidade de produtos consumidos.
            //O critério para que não seja mais solicitado o código do produto ao cliente é se o mesmo
            //informar o código 16.

            int codigo = 0;
            int quantidadeProdutos = 0;
            double valorTotal = 0;

            while (codigo != 16) {
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

                Console.WriteLine("Escolha seu pedido: ");
                int escolhaPedido = Convert.ToInt32(Console.ReadLine());

                if (codigo == 1)
                    
 





}


        }






    }
}
