using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioLista.Exercicio01
{
    public class Exercicio01
    {
        public void Executar() {

        List<string> melhoresFilmes = new List<string>();
        melhoresFilmes.Add("Dragon Ball Evollution");
        melhoresFilmes.Add("Titanic");
        melhoresFilmes.Add("Lanterna Verde");

            Console.Write("[0]: " + melhoresFilmes[0] +
                "\n" + "[1]: " + melhoresFilmes[1] +
                "\n" + "[2]: " + melhoresFilmes[2]);

            melhoresFilmes.Add(" ");

            melhoresFilmes[0] = "Dragon Ball Super: Broly";
            melhoresFilmes.RemoveAt(2);

            var contemLanternaVerde = melhoresFilmes.Contains("Lanterna Verde");
             
            if(contemLanternaVerde == true)
            {
                Console.WriteLine("Está cadastrado!");


            } else
            {
                Console.WriteLine("Não está cadastrado!");

            }

            melhoresFilmes.Add("Quarteto Fantástico");

            Console.WriteLine("[0]: " + melhoresFilmes[0]
                + "\n" + "[1]: " + melhoresFilmes[1] + "[2]: " + melhoresFilmes[2] +
                "\n" + "[2]" + melhoresFilmes[2] + "\n" + "[3]: " + melhoresFilmes[3]);


            var indiceNome = melhoresFilmes.IndexOf("Titanic");
            melhoresFilmes[indiceNome] = "Titanic 2";


            Console.WriteLine("[0]: " + melhoresFilmes[0]
                + "\n" + "[1]: " + melhoresFilmes[1] + "[2]: " + melhoresFilmes[2] +
                "\n" + "[2]" + melhoresFilmes[2] + "\n" + "[3]: " + melhoresFilmes[3]);


            var contemLagoaAzul = melhoresFilmes.Contains("Lagoa Azul");

            if (contemLagoaAzul == false) {

                Console.WriteLine("Não contém o filme lagoa azul");

            
            
            } else {

                Console.WriteLine("Contém o filme Lagoa Azul");
            }




        }
    }
}
