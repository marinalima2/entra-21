using Entra21.ExerciciosOrientacaoObjetos;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(@"
 ___________________________
|Exercício 1 - Digite 1     |
|Exercício 2 - Digite 2     |
|Exercício 3 - Digite 3     |
|Exercício 4 - Digite 4     |
|Exercício 5 - Digite 5     |
|___________________________|

");

Console.WriteLine("Informe uma opçaõ: ");
int opcaoDesejada = 1;

if (opcaoDesejada == 1)
{
    ExercicioLivro exercicioLivro = new ExercicioLivro();
    exercicioLivro.Executar();


}