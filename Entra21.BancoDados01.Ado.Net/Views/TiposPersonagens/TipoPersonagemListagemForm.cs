using Entra21.BancoDados01.Ado.Net.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemServico tipoPersonagemServico;

        public TipoPersonagemListagemForm()
        {
            InitializeComponent();

            tipoPersonagemServico = new TipoPersonagemServico();

        }

        private void TipoPersonagemListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGReedView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicaoForm = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGReedView();
        }

        private void AtualizarRegistrosDataGReedView()
        {
            var tiposPersonagens = tipoPersonagemServico.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridView1.Rows.Add(new object[]
                    {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo

                    });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemServico.Apagar(id);

            AtualizarRegistrosDataGReedView();

            MessageBox.Show("Registro apagado com sucesso");
        }
    }
}
