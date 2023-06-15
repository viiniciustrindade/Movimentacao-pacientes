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
        public string codProntuario { get; private set; }
        public string localizacao { get; private set; }
        public string leito { get; private set; }
        public string centroCusto { get; private set; }
        public string clinica { get; private set; }
        public string medico { get; private set; }
        public string crm { get; private set; }

        public void FecharFormulario()
        {
            codigo = txtcodPaciente.Text;
            nome = txtNomePaciente.Text;
            this.Close();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid4.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                PacienteDAO dao = new PacienteDAO(connection);
                List<MovModel> movimentacoes = dao.GetPacientes();
                foreach (MovModel movimento in movimentacoes)
                {
                    DataGridViewRow row = dadosGrid4.Rows[dadosGrid4.Rows.Add()];
                    row.Cells[colCodigoPaciente.Index].Value = movimento.PacienteModel.codPaciente;
                    row.Cells[colCodProntuario.Index].Value = movimento.ProntuarioModel.codProntuario;
                    row.Cells[colNomePaciente.Index].Value = movimento.nomePaciente.nomePaciente;
                    row.Cells[colMaePaciente.Index].Value = movimento.maePaciente.mae;
                    row.Cells[colDataNasc.Index].Value = movimento. dataNasc.dataNasc;
                    row.Cells[colLocalizacao.Index].Value = movimento.localizacao;
                    row.Cells[colLeito.Index].Value = movimento.leito;
                    row.Cells[colCentroCusto.Index].Value = movimento.centroCusto;
                    row.Cells[colClinicaMedica.Index].Value = movimento.clinicaMedica;
                    row.Cells[colMedico.Index].Value = movimento.medico;
                    row.Cells[colCrm.Index].Value = movimento.crm;
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
                nomeDaMae = dadosGrid4.Rows[e.RowIndex].Cells[colMaePaciente.Index].Value + "";
                codProntuario = dadosGrid4.Rows[e.RowIndex].Cells[colCodProntuario.Index].Value + "";
                localizacao = dadosGrid4.Rows[e.RowIndex].Cells[colLocalizacao.Index].Value + "";
                leito = dadosGrid4.Rows[e.RowIndex].Cells[colLeito.Index].Value + "";
                centroCusto = dadosGrid4.Rows[e.RowIndex].Cells[colCentroCusto.Index].Value + "";
                clinica = dadosGrid4.Rows[e.RowIndex].Cells[colClinicaMedica.Index].Value + "";
                medico = dadosGrid4.Rows[e.RowIndex].Cells[colMedico.Index].Value + "";
                crm = dadosGrid4.Rows[e.RowIndex].Cells[colCrm.Index].Value + "";
                
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
