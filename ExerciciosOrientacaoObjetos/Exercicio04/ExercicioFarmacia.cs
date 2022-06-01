using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio04
{
    public class ExercicioFarmacia
        
    {

        public void Executar()
        {


            Farmacia farmacia = new Farmacia();


            Console.WriteLine("Informe a razão social da farmácia: ");
            farmacia.RazaoSocial = Console.ReadLine();
            Console.WriteLine("Informe o CNPJ: ");
            farmacia.Cnpj = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Informe o nome do 1° produto: ");
            farmacia.NomeProduto1 = Console.ReadLine();
            Console.WriteLine("Informe o valor do 1° produto: ");
            farmacia.PrecoProduto1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a categoria do 1° produto: ");

            Console.WriteLine("Informe o nome do ");







        }






    }
}
