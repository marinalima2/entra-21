using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetosTestes.Exercicio02
{
    public class TemperaturaTestes
    {

        [Fact]
        public void Validar_CalcularCelsiusParaKelvin()
        {
            //Arrange 
            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 50;

            // Act
            var temperaturaConvertida = temperatura.CalcularCelsiusParaKelvin();

            //Assert 
            temperaturaConvertida.Should().Be(323);
        }

        [Fact]

        public void Validar_CalcularCelsiusParaFahrenheit()
        {

            //Arrange

            var temperatura = new ExercicioTemperatura();
            temperatura.ValorTemperatura = 60;

            // Act 
            var temperaturaConvertida = temperatura.CalcularCelsiusParaFahrenheit();

            //Assert 
            temperaturaConvertida.Should().Be(140);

        }

        public void Validar_CalcularKelvinParaCelsius()
        {
            //ARRANGE 

            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 90;

            //ACT

            var temperaturaConvertida = temperatura.CalcularKelvinParaCelsius();

            // Assert 

            temperaturaConvertida.Should().Be(183);

        }


        public void Validar_CalcularKelvinParaFahrenheit()
        {

            //Arrange

            var temperatura = new Temperatura();
            temperatura.ValorTemperatura = 70;

            //act

            var temperaturaConvertida = temperatura.CalcularKelvinParaFahrenheit();


            //Assert

            temperaturaConvertida.Should().Be(333);





        }
    }
    }
