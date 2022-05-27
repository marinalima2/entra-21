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
} else if (opcaoDesejada == 2)
{
    Exercicio02 exericicio02 = new Exercicio02();
    exericicio02.Executar();

} else if (opcaoDesejada == 3)
{

    Exercicio03 exercicio03 = new Exercicio03();


}




 