using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class ExercicioTemperatura
    {

        public void Executar()
        {
            Temperatura temperatura = new Temperatura();

            Console.WriteLine("Informe a temperatura de origem: ");
            temperatura.temperaturaOrigem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a temperatura de destino: ");
            temperatura.temperaturaDestino = Convert.ToInt32(Console.ReadLine());









        }
        






    }
}
