using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListaObjetos.Exercicio01
{
    public class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;


        public bool ValidarTriangulo()
        {
            var soma = Lado1 + Lado2;
           if(soma> Lado3)
            {
                Console.WriteLine("È um triangulo");
                return true;

            } 
            return false;


        }

    }
}
