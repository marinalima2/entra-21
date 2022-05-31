using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {

        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double ValorTemperatura;

        public double CalcularCelsiusParaKelvin()
        {

            var temperaturaCelsiusKelvin = ValorTemperatura + 273;
            return temperaturaCelsiusKelvin;

        }

        public double CalcularCelsiusParaFahrenheit()
        {
            var celsiusParaFahrenheit = ValorTemperatura * 1.8 + 32;
            return celsiusParaFahrenheit;

        }

        public double CalcularKelvinParaCelsius()
        {

            var celsiusParaKelvin = ValorTemperatura - 273;
            return celsiusParaKelvin;



        }

        public double CalcularKelvinParaFahrenheit()
        {
            var kelvinParaFahrenheit = (ValorTemperatura - 273) * 1.8 + 32;
            return kelvinParaFahrenheit;


        }

        public double CalcularFahrenheitParaCelsius()
        {
            var fahrenheitParaCelsius = (ValorTemperatura - 32) / 1.8;
            return fahrenheitParaCelsius;

        }

        public double CalcularFahrenheitParaKelvin()
        {
            var fahrenheitParaKelvin = (ValorTemperatura - 32) * 5 / 9 + 273;
            return fahrenheitParaKelvin;

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
