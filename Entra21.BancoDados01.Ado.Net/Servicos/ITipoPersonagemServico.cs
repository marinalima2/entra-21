using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Servicos
{
    internal interface ITipoPersonagemServico
    {
        // Interface define o padrão, um molde (contrato - forma)
        //Como ira ser implementado é a classe que reproduz (como que diz que irá ser)

        void Cadastrar(Models.TipoPersonagem tipoPersonagem);

        List<TipoPersonagem> ObterTodos();

        void Apagar(int id);




    }
}
