using Entra21.ExerciciosFOR;

Console.WriteLine(@"
  ______________________________
 |____________MENU______________|
 |                              |
 |1 - Exercício 01              |
 |5 - Exercício 05              |
 |8 - Exercício 08              |
 |10 - Exercício 10             |
 |12 - Exercício 12             |
 |13 - Exercício 13             |
 |______________________________|

");
Console.WriteLine("\n Escolha a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());


if (opcaoDesejada == 1) {
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();

} else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();

}