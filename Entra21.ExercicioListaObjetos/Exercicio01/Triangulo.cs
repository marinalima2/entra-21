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
            var soma0 = Lado1 + Lado2;
            var soma1 = Lado1 + Lado3;
            var soma2 = Lado2 + Lado3;

            if (soma0 > Lado3)
            {
                Console.WriteLine("É um triângulo");
                return true;
            }
            else if (soma1 > Lado2)
            {
                Console.WriteLine("É um triângulo");
            }
            else if (soma2 > Lado1)
            {
                Console.WriteLine("É um triângulo");
                return true;
            }

            return false;
            Console.WriteLine("Não é um triângulo");
        }
    }
}
