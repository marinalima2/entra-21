using Entra21.ExerciciosVetorWhile;



Console.WriteLine(@"
  __________________________
 |           MENU           |      
 |                          |
 |Exercício 1               |
 |                          |
 |");
 
Console.WriteLine("Informe a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());


if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01(); 
    exercicio01.Executar();
}


 