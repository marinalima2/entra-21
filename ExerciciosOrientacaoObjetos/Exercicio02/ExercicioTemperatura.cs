using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class ExercicioTemperatura
    {
        public int ValorTemperatura;

        public void Executar()
        {

            Temperatura temperatura = new Temperatura();

            Console.WriteLine("Informe a temperatura origem: ");
            temperatura.TemperaturaOrigem = Console.ReadLine().ToLower();



            Console.WriteLine("Informe a temperatura de destino: ");
            temperatura.TemperaturaDestino = Console.ReadLine();

            Console.WriteLine("Valor da temperatura: ");
            temperatura.ValorTemperatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(temperatura.ObterTemperaturaConvertida());




        }

        public object CalcularCelsiusParaFahrenheit()
        {
            throw new NotImplementedException();
        }
    }
}
