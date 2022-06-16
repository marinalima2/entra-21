using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForm1.Exemplo01
{
    public partial class PacientesForm : Form
    {

        private int codigo = 1;
        private int indiceLinhaSelecionada= -1;
        private int codigoSelecionado = -1;

        public PacientesForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());
            var imc = peso/(altura*altura);

            if(indiceLinhaSelecionada == -1 )
            {
                dataGridView1.Rows.Add(new object[] { codigo++, nome, peso, altura, imc });
                return;
            }

            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada ].Cells[4].Value = imc.ToString();



            dataGridView1.Rows.Add(new object[] {
                codigo++ , nome, altura, peso, imc

            });



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if(indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar? ", "Aviso", MessageBoxButtons.YesNo);

            //Verifica se o usuário escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                //Remove linha utilizando o indice do DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;   
            if(indiceLinhaSelecionada== -1)
            {
                MessageBox.Show("Selecione um paciente");
                return;

            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);  
            var nome = linhaSelecionada.Cells[1].ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();


        }
    }
}
