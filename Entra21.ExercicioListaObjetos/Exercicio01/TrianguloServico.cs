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

        public bool Adicionar (int lado1, int lado2, int lado3, int codigoAtual)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;    
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;
            triangulo.Codigo = codigoAtual;
            triangulo.Codigo = codigoAtual + 1;

            triangulos.Add(triangulo);
            return true;
        }

        public bool Editar (int codigoNovo, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoNovo); ;
            
            if(trianguloParaAlterar == null)
            {
                return false;
            }
            trianguloParaAlterar.Lado1 = lado1;
            trianguloParaAlterar.Lado2 = lado2;
            trianguloParaAlterar.Lado3 = lado3;
            return true;
        }

        public bool Apagar(int codigo)
        {
            for(int i = 0; i < triangulos.Count; i++)
            {
                Triangulo triangulo = triangulos[1];
                if(triangulo.Codigo == codigo)
                {
                    triangulos.Remove(triangulo);
                }
            }
            return true;

        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if(trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }
            return null;
        }
    }
}
