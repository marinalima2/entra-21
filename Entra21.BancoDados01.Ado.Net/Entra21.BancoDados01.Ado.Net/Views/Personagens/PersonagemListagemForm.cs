using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemListagemForm : Form
    {

        //Definindo como redonly será permitida acriação da instancia somente no construtor
        private readonly PersonagemService _personagemService; //_ na frente SEMPRE que for readolny
        private readonly int idade;

        //Aqui fica o construtor: Tem como objetivo construir o objeto com
        //propriedades necessárias e execução de métodos obrigatórios,
        //ou seja, neste cenário desenhar a tela e instanciar o objeto dp serviço
        //que permitirá gerenciar os dados referentes ao personagem 
        public PersonagemListagemForm()
        {
            InitializeComponent();

            _personagemService = new PersonagemService();

            idade = 10;
            PreencherDataGridViewComPersonagens();
        }

        private void PreencherDataGridViewComPersonagens()
        {
            var personagens = _personagemService.ObterTodos();

            for (int i = 0; i < personagens.Count; i++)
            {
                var personagem = personagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    personagem.Id,
                    personagem.Nome,
                    personagem.TipoPersonagem.Tipo,
                    personagem.Editora.Nome
                }) ;
                }
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemCadastroEdicaoForm();
            personagemForm.ShowDialog();

            PreencherDataGridViewComPersonagens();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _personagemService.Apagar(id);

            PreencherDataGridViewComPersonagens();

            MessageBox.Show("Registro apagado com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
           if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Querido usuário, selecione algum personagem");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var personagem = _personagemService.ObterPorId(id);

            var personagemCadastroForm = new PersonagemCadastroEdicaoForm(personagem);
            personagemCadastroForm.ShowDialog();

            PreencherDataGridViewComPersonagens();


        }
    }
}
