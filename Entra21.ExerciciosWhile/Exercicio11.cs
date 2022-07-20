using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    { 
        public void Executar()
        {

            // Solicite para o usuário dois números. Apresente o seguinte menu e de acordo com a
            // escolha deve ser apresentado a operação aritmética, isto deve ocorrer até que o
            //mesmo escolha a opção de sair

            int opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("Informe o 1° número: ");
                int numeroUm = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o 2° número: ");
                int numeroDois = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(@" 
             _________________________________________________
            |                      Menu                       |
            |-------------------------------------------------|
            |1 -                SOMA                          |           
            |2 -                SUBTRAIR                      |  
            |3 -                MULTIPLICAR                   |
            |4 -                DIVIDIR                       |
            |5 -                SAIR                          |
            |_________________________________________________|");

                Console.WriteLine("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    int soma = numeroUm + numeroDois;
                    Console.WriteLine(" A soma é: " + soma);
                }

                if (opcao == 2)
                {
                    int subtracao = numeroUm - numeroDois;
                    Console.WriteLine("A subtração é: " + subtracao);
                }

                if (opcao == 3)
                {
                    int multiplicacao = numeroUm * numeroDois;
                    Console.WriteLine("A multiplicação é: " + multiplicacao);
                }

                if (opcao == 4)
                {
                    int divisao = numeroUm / numeroDois;
                    Console.WriteLine("A divisão é: " + divisao);
                }
            }
        }
    }
}
