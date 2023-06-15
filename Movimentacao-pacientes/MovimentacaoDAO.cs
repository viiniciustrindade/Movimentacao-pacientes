using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimentacao_pacientes
{
    public class MovimentacaoDAO
    {
        private SqlConnection Connection { get; }
        public MovimentacaoDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(PacienteModel paciente, MovModel movimentacao, ProntuarioModel prontuario)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtMovPac(codPaciente, codProntuario, dataMov, horaMov, motivo, localizacao, leito, centroDeCusto, " +
                        $"clinicaMedica, medico, CRM) VALUES(@codPaciente, @codProntuario, @dataMov, @horaMov, @motivo, @localizacao, " +
                        $"@leito, @CentroDeCusto, @clinicaMedica, @medico, @CRM)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codPaciente", paciente.codPaciente));
                    command.Parameters.Add(new SqlParameter("@codProntuario", prontuario.codProntuario));
                    command.Parameters.Add(new SqlParameter("@dataMov", movimentacao.data));
                    command.Parameters.Add(new SqlParameter("@horaMov", movimentacao.hora));
                    command.Parameters.Add(new SqlParameter("@motivo", movimentacao.motivo));
                    command.Parameters.Add(new SqlParameter("@localizacao", movimentacao.localizacao));
                    command.Parameters.Add(new SqlParameter("@leito", movimentacao.leito));
                    command.Parameters.Add(new SqlParameter("@CentroDeCusto", movimentacao.centroCusto));
                    command.Parameters.Add(new SqlParameter("@clinicaMedica", movimentacao.clinicaMedica));
                    command.Parameters.Add(new SqlParameter("@medico", movimentacao.medico));
                    command.Parameters.Add(new SqlParameter("@CRM", movimentacao.crm));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public bool Validacoes(PacienteModel paciente, ProntuarioModel prontuario, MovModel movimentacao)
        {
            if (string.IsNullOrEmpty(paciente.codPaciente) || string.IsNullOrWhiteSpace(paciente.codPaciente))
            {
                MessageBox.Show("Informe o campo [Codigo paciente!]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(prontuario.codProntuario) || string.IsNullOrWhiteSpace(prontuario.codProntuario))
            {
                MessageBox.Show("Informe o campo [Codigo prontuario]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(movimentacao.data) || string.IsNullOrWhiteSpace(movimentacao.data))
            {
                MessageBox.Show("Informe o campo [Data]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(movimentacao.hora) || string.IsNullOrWhiteSpace(movimentacao.hora))
            {
                MessageBox.Show("Informe o campo [Hora]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(movimentacao.motivo) || string.IsNullOrWhiteSpace(movimentacao.motivo))
            {
                MessageBox.Show("Informe o campo [Motivo]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(movimentacao.localizacao) || string.IsNullOrWhiteSpace(movimentacao.localizacao))
            {
                MessageBox.Show("Informe o campo [Localização]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(movimentacao.leito) || string.IsNullOrWhiteSpace(movimentacao.leito))
            {
                MessageBox.Show("Informe o campo [Leito]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(movimentacao.centroCusto) || string.IsNullOrWhiteSpace(movimentacao.centroCusto))
            {
                MessageBox.Show("Informe o campo [Centro de custo]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(movimentacao.clinicaMedica) || string.IsNullOrWhiteSpace(movimentacao.clinicaMedica))
            {
                MessageBox.Show("Informe o campo [Clinica médica]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(movimentacao.medico) || string.IsNullOrWhiteSpace(movimentacao.medico))
            {
                MessageBox.Show("Informe o campo [Médico]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(movimentacao.crm) || string.IsNullOrWhiteSpace(movimentacao.crm))
            {
                MessageBox.Show("Informe o campo [CRM]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
        public int Verifica(ProntuarioModel prontuario, PacienteModel paciente)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codProntuario) FROM mvtMovPac WHERE codProntuario = @codProntuario AND codPaciente = @codPaciente");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codProntuario", prontuario.codProntuario);
                command.Parameters.AddWithValue("@codPaciente", paciente.codPaciente);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }
        public void AlterarRegistroProntuario(ProntuarioModel prontuario, MovModel movimentacao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtHospRegInt SET dataSaida = @dataSaida, horaSaidade = @horaSaida, situacao = @motivo, " +
                        $"localizacao = @localizacao, leito = @leito, centroDeCusto = @centroDeCusto, clinicaMedica = @clinicaMedica, medico = @medico, CRM = @crm " +
                        $"WHERE codProntuario = @codProntuario");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codProntuario", prontuario.codProntuario));
                    command.Parameters.Add(new SqlParameter("@dataSaida", movimentacao.data));
                    command.Parameters.Add(new SqlParameter("@horaSaida", movimentacao.hora));
                    command.Parameters.Add(new SqlParameter("@motivo", movimentacao.motivo));
                    command.Parameters.Add(new SqlParameter("@localizacao", movimentacao.localizacao));
                    command.Parameters.Add(new SqlParameter("@leito", movimentacao.leito));
                    command.Parameters.Add(new SqlParameter("@centroDeCusto", movimentacao.centroCusto));
                    command.Parameters.Add(new SqlParameter("@clinicaMedica", movimentacao.clinicaMedica));
                    command.Parameters.Add(new SqlParameter("@medico", movimentacao.medico));
                    command.Parameters.Add(new SqlParameter("@crm", movimentacao.crm));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
    }
}
