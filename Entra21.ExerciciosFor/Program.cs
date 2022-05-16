using Entra21.ExerciciosFor;

Console.WriteLine(@"
____________________________
|         MENU             |
|__________________________|
| 1 - Exercício 1          |
| 5 - Exercício 5          |
| 8 - Exercício 8          |
| 10 - Exercício 10        |
| 12 - Exercício 12        |
| 13 - Exercício 13        |
|__________________________|");

Console.WriteLine("\nInforme a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();

}
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();

}
else if (opcaoDesejada == 10) {
    Exercicio10 exercicio10 = new Exercicio10();
    exercicio10.Executar();



}