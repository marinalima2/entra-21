namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {
        public int temperaturaOrigem;
        public int temperaturaDestino;
        public int valorTemperatura;


        public int CalcularCelsiusParaKelvin()
        {
            var temperaturaCelsiusParaKelvin = temperaturaOrigem + 273;
            return temperaturaCelsiusParaKelvin;

        }

        public int CalcularCelsiusParaFahrenheit()
        {

            var temperaturaCelsiusParaFahrenheit = ((temperaturaOrigem * 9) / 5) + 32;
            return temperaturaCelsiusParaFahrenheit;

        }

        public int CalcularKelvinParaCelsius()
        {
            var temperaturaKelvinParaCelsius = temperaturaOrigem - 273;
            return temperaturaKelvinParaCelsius;
        }

        public double CalcularKelvinParaFahrenheit()
        {

            var temperaturaKelvinParaFahrenheit = ((temperaturaOrigem - 273) * 1.8) + 32;
            return temperaturaKelvinParaFahrenheit;

        }

        public double CalcularFahrenheitParaCelsius()
        {

            var temperaturaFahrenheitParaCelsius = ((temperaturaOrigem - 32) * 5 / 9);
            return temperaturaFahrenheitParaCelsius;

        }

        public double CalcularFahrenheitParaKelvin()
        {
            var temperaturaFahrenheitParaKelvin = (((temperaturaOrigem - 32) / 1.8) + 273) * 15;
            return temperaturaFahrenheitParaKelvin;

        }

      

    }
}
