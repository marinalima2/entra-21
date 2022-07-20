using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {
        public int temperaturaOrigem;
        public int temperaturaDestino;
        public int valorTemperatura;

        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double ValorTemperatura;

        {
            var temperaturaCelsiusParaKelvin = temperaturaOrigem + 273;
            return temperaturaCelsiusParaKelvin;

            var temperaturaCelsiusKelvin = ValorTemperatura + 273;
            return temperaturaCelsiusKelvin;

        }

        {

        }

        {
        }

        public double CalcularKelvinParaFahrenheit()
        {
            var kelvinParaFahrenheit = (ValorTemperatura - 273) * 1.8 + 32;
            return kelvinParaFahrenheit;

            var temperaturaKelvinParaFahrenheit = ((temperaturaOrigem - 273) * 1.8) + 32;
            return temperaturaKelvinParaFahrenheit;

        }

        public double CalcularFahrenheitParaCelsius()
        {

        }

        public double CalcularFahrenheitParaKelvin()
        {

        }




        public double ObterTemperaturaConvertida()
        {
            if (TemperaturaOrigem == "celsius" && TemperaturaDestino == "kelvin")
            {
                return CalcularCelsiusParaKelvin();

            }
            else if (TemperaturaOrigem == "celsius" && TemperaturaDestino == "farenheit")
            {
                return CalcularCelsiusParaFahrenheit();

            }
            else if (TemperaturaOrigem == "kelvin" && TemperaturaDestino == "celsius")
            {
                return CalcularKelvinParaCelsius();

            }
            else if (TemperaturaOrigem == "kelvin" && TemperaturaDestino == "fahrenheit")
            {

                return CalcularKelvinParaFahrenheit();

            }
            else if (TemperaturaOrigem == "fahrenheit" && TemperaturaDestino == "celsius")
            {
                return CalcularFahrenheitParaCelsius();


            }
            else if (TemperaturaOrigem == "fahrenheit" && TemperaturaDestino == "kelvin")
            {

                return CalcularFahrenheitParaKelvin();
            }

            return 0;

        }


    }
}
