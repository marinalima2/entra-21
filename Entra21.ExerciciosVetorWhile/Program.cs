using Entra21.ExerciciosVetorWhile;

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine(@"
  __________________________
 |           MENU           |      
 |Exercício 1               |
 |Exercício 2               |
 |Exercício 3               |
 |Exercício 4               |
 |Exercício 5               |
 |Exercício 6               |
 |Exercício 7               |
  --------------------------
");
 Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Informe a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());


if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 exericicio02 = new Exercicio02();
    exericicio02.Executar();

}
else if (opcaoDesejada == 3)
{

    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();

}
else if (opcaoDesejada == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();

}
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();

}
else if (opcaoDesejada ==6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (opcaoDesejada ==7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();

}



 