﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio04
{
     public class Farmacia
    {

        public string RazaoSocial;
        public int Cnpj;
        public string NomeProduto1;
        public double PrecoProduto1;
        public string CategoriaProduto1;
        public string NomeProduto2;
        public double PrecoProduto2;
        public string CategoriaProduto2;
        public string NomeProduto3;
        public double PrecoProduto3;
        public string CategoriaProduto3;
        



        public double ApresentarTotalDoPedido() { 
        
            return PrecoProduto1 + PrecoProduto2+ PrecoProduto3;
        
        
        }

        //public double ApresentarTotalDoPedidoPorCategoria() { 
        
        





        
        //}






    }
}
