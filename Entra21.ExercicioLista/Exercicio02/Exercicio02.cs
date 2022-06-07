using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioLista.Exercicio02
{
    public class Exercicio02
    {
        public void Executar()
        {

            List<string> lista = new List<string>();
            lista.Add("Como fazer um bolo");

            Console.WriteLine("[0]: " + lista[0]);

            var alterarBolo = lista.IndexOf("Como fazer um bolo");
            lista[alterarBolo] = "Algoritmos onde vivem? Do que se alimentam";

            lista.Add("Variáveis");
            lista.Add("Mais para frente");

            var alterarMaisFrente = lista.IndexOf("Mais para frente");
            lista[alterarMaisFrente] = "If com E";

            lista.Add("If com OU");
            lista.Add("While");
            lista.Add("For");

            Console.WriteLine("[0]: " + lista[0] + 
                "\n[1]: " + lista[1] + 
                "\n[2]: " + lista[2] + 
                "\n[3]: " + lista[3] +
                "\n[4]: " + lista[4] + 
                "\n[5]: " + lista[5]);

            lista.Add("Vetor");
            lista.Add("Vetor");



            lista.Remove("Vetor");
            lista.Remove("Vetor");

            












        }
    }
}
