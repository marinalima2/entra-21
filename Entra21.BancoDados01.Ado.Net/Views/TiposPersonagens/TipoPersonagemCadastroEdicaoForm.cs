using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Servicos;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemCadastroEdicaoForm : Form
    {
        public TipoPersonagemCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = textBox1.Text.Trim();

            var tipoPersonagem = new TipoPersonagem();
            tipoPersonagem.Tipo = tipo;

            var tipoPersonagemServico = new TipoPersonagemServico();

            tipoPersonagemServico.Cadastrar(tipoPersonagem);

            MessageBox.Show("Tipo de personagem cadastrado com sucesso");

        }
    }
}
