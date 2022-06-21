using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForm1.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        //Construtor mais para frente 
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();

        }

        //Método Adicionar recebe cmo parametro o objeto do endereço completo do Form(Controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {

            //Percorre a lista de endereços afim de encontrar o endereço que deve ser alterado 
            for(int i = 0; i < enderecos.Count; i++)
            {
                //Obtem o endereço da lista de endereços 
                var endereco = enderecos[i];

                //Verifica se o código do endereço percorrido é o mesmo do endereço que deve ser alterado
               if (endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    //Atualiza campos de endereço encontrados
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep; 
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivo();
                }
            }
        }

        public void Apagar(int codigoParaApagar)
        {

            //Percorre a lista de endereços afim de encontrar o edereço que deve ser removido

            for(int i = 0; i < enderecos.Count; i++)
            {
                //Obtém o endereço percorrido
                var endereco =enderecos[i];

                if(endereco.Codigo == codigoParaApagar)
                {
                    //Remove o endereço encontrado na lista de endereços 
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;

                }
            }
        }

        public List<Endereco> ObterTodos()
        {
            return enderecos;

        }

        public void ObterPorCodigo(int codigo)
        {

        }

        public void SalvarArquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("Enderecos.json", enderecosEmJson);
        }


        public void LerArquivo()
        {
            //Verifica se o endereço não existe 

            if (File.Exists("enderecos.json") == false)
                return;

            //Ler o arquivo JSON e converta para uma lista de objetos de endereços 
            //var enderecosEmJson = File.ReadAllText
        }

    }
}
