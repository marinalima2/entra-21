using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class Livro
    {

        public string Titulo;
        public string Autor;
        public int CodigoIsbn;
        public string IdiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int Releitura;

        public string ObterTituloAutor()
        {
            var texto = Titulo + Autor;

            return texto;
        }

        public int ObterQuantidadePaginasParaLer ()
        {
            var paginasParaLer = QuantidadePaginas - QuantidadePaginasLidas;
            return paginasParaLer;
        }

        public int ObterPaginasLidas()
        {
            var paginasLidasNoTotal = QuantidadePaginasLidas;
            return paginasLidasNoTotal;

        }

        public int ObterQuantidadeAnosAposPublicacao()
        {
            var anosAposPublicacao = DataLancamento.Year - DateTime.Now.Year;
            return anosAposPublicacao;
        }






    }
}
