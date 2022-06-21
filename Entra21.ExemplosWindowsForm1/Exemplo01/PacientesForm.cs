using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForm1.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private List<Paciente> pacientes;

        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;

        public PacientesForm()
        {
            InitializeComponent();

            //Cria uma lista de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();

            //Ler do arquivo JSON os pacientes cadastrados anteriormente
            LerArquivoApresentandoPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            //Calcular IMC
            var imc = peso / (altura * altura);

            //Verifica se está em modo de adição 
            if (indiceLinhaSelecionada == -1)
            {
                dataGridView1.Rows.Add(new object[] { ++codigo, nome, peso, altura, imc });

                AdicionarPacienteSalvandNoArquivo(codigo, nome, peso, altura);

                return;
            }

            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var quantidadeLinhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar? ", "Aviso", MessageBoxButtons.YesNo);

            //Verifica se o usuário escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

                //Remove linha utilizando o indice do DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);

                pacientes.RemoveAt(indiceLinhaSelecionada);

                //
                SalvarEmArquivo();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;
            if (indiceLinhaSelecionada == -1)
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

        private void PacientesForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelImc_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarPacienteSalvandNoArquivo(int codigo, string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = codigo,
                Nome = nome,
                Altura = altura,
                Peso = peso
            };

            pacientes.Add(paciente);
            SalvarEmArquivo();
            LimparCampos();

        }

        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[indiceLinhaSelecionada].Nome = nome;
            pacientes[indiceLinhaSelecionada].Peso = peso;
            pacientes[indiceLinhaSelecionada].Altura = altura;

            SalvarEmArquivo();
            LimparCampos();

        }

        private void SalvarEmArquivo()
        {
            //Converter uma lista de objetos em uma string contendo o JSON
            var pacientesEmJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.json";

            //Salvar a string contendo o JSON em um arquivo no Formato JSON
            File.WriteAllText(caminho, pacientesEmJson);

        }

        private void LimparCampos()
        {
            textBoxPeso.Text = "";
            textBoxNome.Text = "";
            textBoxAltura.Text = "";

            indiceLinhaSelecionada = -1;
            dataGridView1.ClearSelection();

        }

        private void LerArquivoApresentandoPacientes()
        {
            //Validar se arquivo não existe consequentemente não é necessário percorrer uma lista
            if (File.Exists("pacientes.json") == false)
                return;


            var conteudoArquivo = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);
            var maiorCodigo = int.MinValue;

            for (int i = 0; i < pacientes.Count; i++)
            {
                //Obtem o paciente que está sendo percorrido
                var paciente = pacientes[i];

                dataGridView1.Rows.Add(new object[] {
                    paciente.Codigo, paciente.Nome,
                    paciente.Altura, paciente.Peso,
                    CalcularImc(paciente.Peso, paciente.Altura)
                });
                //Retorna para descobrir o paciente com o maior código 
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;
            }
            //Validar se conseguiu encontrar algum código, caso contrário não deve atualizar o código do novo paciente

            if (maiorCodigo != int.MinValue)
                codigo = maiorCodigo;

        }

        private double CalcularImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
     
        }

    }
}
