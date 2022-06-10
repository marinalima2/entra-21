using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListaObjetos.Exercicio01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        private int codigoAtual = 1;
        public bool Adicionar(int lado1, int lado2, int lado3, int codigoAtual)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;
            triangulo.Codigo = codigoAtual;
            triangulo.Codigo = codigoAtual + 1;

            triangulos.Add(triangulo);
        }

        //public bool Editar (int codigoNovo, int lado1, int lado2, int lado3)
        //{





        //}
    }
}
