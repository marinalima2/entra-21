

using Entra21.ExemplosWhile;

Console.WriteLine(@"------MENU------
1 - Exemplo 01
2 - Exemplo 02
3 - Exemplo 03");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    // NomeDaClasse nomeVariavel = new NomeDaClasse();
    Exemplo01 meuExemplo = new Exemplo01();
    meuExemplo.Executar();
}
else if (opcaoDesejada == 2)
{
    Exemplo02 nossoExemplo = new Exemplo02();
    nossoExemplo.Executar();
}
else if (opcaoDesejada == 3)
{
    Exemplo03 delesExemplo = new Exemplo03();
    delesExemplo.Executar();
}