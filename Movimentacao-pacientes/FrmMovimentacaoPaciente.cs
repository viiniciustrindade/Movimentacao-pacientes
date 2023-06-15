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
                txtCodPaciente.Text = paciente.codigo;
                txtCodProntuario.Text = paciente.codProntuario;
                txtLocalizacao.Text = paciente.localizacao;
                txtLeito.Text = paciente.leito;
                txtCentroCusto.Text = paciente.centroCusto;
                txtClinicaMedica.Text = paciente.clinica;
                txtMedico.Text = paciente.medico;
                txtCrm.Text = paciente.crm;
                lblNomePaciente.Visible = false;
                lblExibirMae.Visible = false;
                lblExibirIdade.Visible = false;
            }
            else
            {
                txtCodPaciente.Text = paciente.codigo;
                txtCodProntuario.Text = paciente.codProntuario;
                txtLocalizacao.Text = paciente.localizacao;
                txtLeito.Text = paciente.leito;
                txtCentroCusto.Text = paciente.centroCusto;
                txtClinicaMedica.Text = paciente.clinica;
                txtMedico.Text = paciente.medico;
                txtCrm.Text = paciente.crm;
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
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    MovimentacaoDAO dao = new MovimentacaoDAO(connection);
                    bool verificaRegistros = dao.Validacoes(new PacienteModel()
                    {

                        codPaciente = txtCodPaciente.Text

                    }, new ProntuarioModel()
                    {

                        codProntuario = txtCodProntuario.Text

                    }, new MovModel()
                    {

                        data = dtpData.Value.ToString(),
                        hora = dtpHora.Value.ToString(),
                        motivo = cbxMotivo.Text,
                        localizacao = txtLocalizacao.Text,
                        leito = txtLeito.Text,
                        centroCusto = txtCentroCusto.Text,
                        clinicaMedica = txtClinicaMedica.Text,
                        medico = txtMedico.Text,
                        crm = txtCrm.Text

                    });
                    dao.AlterarRegistroProntuario(new ProntuarioModel()
                    {
                        codProntuario = txtCodProntuario.Text
                    }, new MovModel()
                    { 
                        data = dtpData.Value.Date.ToString(),
                        hora = dtpHora.Value.ToString(),
                        motivo = cbxMotivo.Text,
                        localizacao = txtLocalizacao.Text,
                        leito = txtLeito.Text,
                        centroCusto = txtCentroCusto.Text,
                        clinicaMedica = txtClinicaMedica.Text,
                        medico = txtMedico.Text,
                        crm = txtCrm.Text

                    });

                    dao.Salvar(new PacienteModel()
                    {

                        codPaciente = txtCodPaciente.Text

                    }, new MovModel()
                    {
                        data = dtpData.Value.Date.ToString(),
                        hora = dtpHora.Value.ToString(),
                        motivo = cbxMotivo.Text,
                        localizacao = txtLocalizacao.Text,
                        leito = txtLeito.Text,
                        centroCusto = txtCentroCusto.Text,
                        clinicaMedica = txtClinicaMedica.Text,
                        medico = txtMedico.Text,
                        crm = txtCrm.Text

                    }, new ProntuarioModel()
                    {

                        codProntuario = txtCodProntuario.Text

                    });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar a movimentação do paciente !\n{ex.Message}");
            }
        }
    }
}
