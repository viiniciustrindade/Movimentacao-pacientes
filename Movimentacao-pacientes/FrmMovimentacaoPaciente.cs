using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimentacao_pacientes
{
    public partial class FrmMovimentacaoPaciente : Form
    {
        public FrmMovimentacaoPaciente()
        {
            InitializeComponent();
        }
        public void AbrirSelecaoPaciente()
        {
            SelecionarPaciente paciente = new SelecionarPaciente();
            paciente.ShowDialog();
            if (string.IsNullOrEmpty(paciente.nome) || string.IsNullOrWhiteSpace(paciente.nome))
            {
                lblNomePaciente.Visible = false;
                lblExibirMae.Visible = false;
                lblExibirIdade.Visible = false;
            }
            else
            {
                txtCodPaciente.Text = paciente.codigo;
                lblNomePaciente.Text = $"Paciente: {paciente.nome}";
                lblExibirIdade.Text = $"Idade: {paciente.idadeOf} anos";
                lblExibirMae.Text = $"Mãe: {paciente.nomeDaMae}";

                lblNomePaciente.Visible = true;
                lblExibirMae.Visible = true;
                lblExibirIdade.Visible = true;
            }
        }
        public void AbrirSelecaoCentroCusto()
        {
            BuscarCentroCusto centro = new BuscarCentroCusto();
            centro.ShowDialog();
            txtCentroCusto.Text = centro.nomeCentroCusto;
        }

        private void btnCarregarPaciente_Click(object sender, EventArgs e)
        {
            AbrirSelecaoPaciente();
        }

        private void btnCarregarCentroCusto_Click(object sender, EventArgs e)
        {
            AbrirSelecaoCentroCusto();
        }

        private void FrmMovimentacaoPaciente_Load(object sender, EventArgs e)
        {
            dtpHora.Value = DateTime.Now;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
