using Entra21.ExercicioLista;
using Entra21.ExercicioLista.Exercicio01;

Console.WriteLine(@"---------MENU---------
Exercicio01 = digite 1
Exercicio02 = digite 2
Exercicio03 = digite 3");


Console.WriteLine("Informe uma opçaõ: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{

    Exercicio01 exercicio = new Exercicio01();
    exercicio.Executar();
}
//else if (opcaoDesejada == 2)
//{

//    Exercicio02 exercicio2 = new Exercicio02();
//    exercicio2.Executar();

//}

//else if (opcaoDesejada == 3)
//{

//    Exercicio03 exercicio3 = new Exercicio03();
//    exercicio3.Executar();

//}



