using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimentacao_pacientes
{
    public partial class SelecionarPaciente : Form
    {
        public SelecionarPaciente()
        {
            InitializeComponent();
        }

        private void SelecionarPaciente_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
        }
        public string codigo { get; private set; }
        public string nome { get; private set; }
        public string nomeDaMae { get; private set; }
        public string idadeOf { get; private set; }
        public void FecharFormulario()
        {
            codigo = txtcodPaciente.Text;
            nome = txtNomePaciente.Text;
            nomeDaMae = txtMae.Text;
            this.Close();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid4.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                PacienteDAO dao = new PacienteDAO(connection);
                List<PacienteModel> pacientes = dao.GetPacientes();
                foreach (PacienteModel paciente in pacientes)
                {
                    DataGridViewRow row = dadosGrid4.Rows[dadosGrid4.Rows.Add()];
                    row.Cells[colCodigoPaciente.Index].Value = paciente.codPaciente;
                    row.Cells[colNomePaciente.Index].Value = paciente.nomePaciente;
                    row.Cells[colMaePaciente.Index].Value = paciente.mae;
                    row.Cells[colDataNasc.Index].Value = paciente.dataNasc;
                }
            }
        }

        private void txtNomePaciente_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomePaciente.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid4.Rows)
            {
                string nomeAutor = row.Cells[colNomePaciente.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtcodPaciente_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtcodPaciente.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid4.Rows)
            {
                string nomeAutor = row.Cells[colCodigoPaciente.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void dadosGrid4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtcodPaciente.Text = dadosGrid4.Rows[e.RowIndex].Cells[colCodigoPaciente.Index].Value + "";
                txtNomePaciente.Text = dadosGrid4.Rows[e.RowIndex].Cells[colNomePaciente.Index].Value + "";
                dtpDataNascimento.Text = dadosGrid4.Rows[e.RowIndex].Cells[colDataNasc.Index].Value + "";
                txtMae.Text = dadosGrid4.Rows[e.RowIndex].Cells[colMaePaciente.Index].Value + "";

                FecharFormulario();
            }
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataNascimento = dtpDataNascimento.Value;
            int idade = CalcularIdade(dataNascimento);
            idadeOf = idade.ToString();
        }
        private int CalcularIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
    }
}
