using Entra21.ExerciciosWhile;

Console.WriteLine(@"------MENU------
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03
4 - Exercicio 04
5 - Exercicio 05");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if(opcaoDesejada == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
} else if (opcaoDesejada == 3 ) {
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
} else if(opcaoDesejada == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
} else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}