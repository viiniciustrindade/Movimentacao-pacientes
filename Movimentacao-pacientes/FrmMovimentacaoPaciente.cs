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
        private void LoadId()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtMovPac') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());

                txtCodSequencia.Text = proximoID.ToString();

            }
        }
        public void ApagarCampos()
        {
            txtCodPaciente.Text = "";
            txtCodProntuario.Text = "";
            dtpData.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            cbxMotivo.SelectedIndex = -1;
            txtLocalizacao.Text = "";
            txtLeito.Text = "";
            txtCentroCusto.Text = "";
            txtClinicaMedica.Text = "";
            txtMedico.Text = "";
            txtCrm.Text = "";
            lblNomePaciente.Text = "";
            lblExibirMae.Text = "";
            lblExibirIdade.Text = "";
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
            LoadId();
            dtpHora.Value = DateTime.Now;
            dtpData.Value = DateTime.Today;
            
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
                        centroCusto = txtCentroCusto.Text,
                        medico = txtMedico.Text,
                        crm = txtCrm.Text

                    });
                    if (verificaRegistros)
                    {
                        int count = dao.Verifica(new ProntuarioModel()
                        {
                            codProntuario = txtCodProntuario.Text
                        },
                        new PacienteModel()
                        {
                            codPaciente = txtCodPaciente.Text
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

                        dao.AlterarCadastroPaciente(new PacienteModel()
                        {
                            codPaciente = txtCodPaciente.Text
                        }, new MovModel() 
                        { 
                            motivo = cbxMotivo.Text
                        });
                        
                        MessageBox.Show("Movimentação salva com sucesso!");
                        NovoMetodo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar a movimentação do paciente !\n{ex.Message}");
            }
        }

        private void cbxMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMotivo.Text == "Alta")
            {
                txtLocalizacao.Text = "";
                txtLocalizacao.Enabled = false;
                txtLeito.Text = "";
                txtLeito.Enabled = false;
                txtCentroCusto.Text = "Liberado";
                txtCentroCusto.Enabled = false;
                btnCarregarCentroCusto.Enabled = false;
                txtClinicaMedica.Enabled = false;
            }
            else if (cbxMotivo.Text == "Óbito")
            {
                txtLocalizacao.Text = "Cemitério";
                txtLocalizacao.Enabled = true;
                txtLeito.Text = "Túmulo";
                txtLeito.Enabled = true;
                txtCentroCusto.Text = "Encerrado";
                txtCentroCusto.Enabled = false;
                btnCarregarCentroCusto.Enabled = false;
                txtClinicaMedica.Enabled = false;
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            NovoMetodo();
        }
        public void NovoMetodo()
        {
            ApagarCampos();
            LoadId();
            txtLocalizacao.Enabled = true;
            txtCentroCusto.Enabled = true;
            txtLeito.Enabled = true;
            btnCarregarCentroCusto.Enabled = true;
            txtClinicaMedica.Enabled = true;
        }
        private void txtCodProntuario_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                MovimentacaoDAO dao = new MovimentacaoDAO(connection);
                string data = dao.VerificaDataSaida(new ProntuarioModel()
                {
                    codProntuario = txtCodProntuario.Text
                });
                string hora = dao.VerificaHoraSaida(new ProntuarioModel()
                {
                    codProntuario = txtCodProntuario.Text
                });

                DateTime dataMinima;
                if (DateTime.TryParse(data, out dataMinima))
                {
                    dtpData.MinDate = dataMinima;
                }
                else
                {
                    dtpData.MinDate = DateTime.Today;
                    dtpHora.MinDate = DateTime.Today;
                }
            }
        }
        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                MovimentacaoDAO dao = new MovimentacaoDAO(connection);
                string data = dao.VerificaDataSaida(new ProntuarioModel()
                {
                    codProntuario = txtCodProntuario.Text
                });
                string hora = dao.VerificaHoraSaida(new ProntuarioModel()
                {
                    codProntuario = txtCodProntuario.Text
                });

                DateTime dataMinima;
                if (DateTime.TryParse(data, out dataMinima))
                {
                    dtpData.MinDate = dataMinima;

                    if (DateTime.Compare(dtpData.Value.Date, dataMinima.Date) == 0)
                    {
                        DateTime horaMinima;
                        if (DateTime.TryParse(hora, out horaMinima))
                        {
                            dtpHora.MinDate = horaMinima;
                        }
                        else
                        {
                            dtpHora.MinDate = DateTime.Today;
                        }
                    }
                    else if (DateTime.Compare(dtpData.Value.Date, dataMinima.Date) > 0)
                    {
                        dtpHora.MinDate = DateTime.Today;
                    }
                }
                else
                {
                    dtpData.MinDate = DateTime.Today;
                    dtpHora.MinDate = DateTime.Today;
                }
            }
        }
    }
}

