using ConsoleTables;

var table = new ConsoleTable("Menu");

table.Configure(x => x.EnableCount = false);

table.AddRow("1 - Exercicio 1")
     .AddRow("5 - Sair       ");

table.Write();

var opcaoDesejada = 0;
if(opcaoDesejada == 1)
{

}
