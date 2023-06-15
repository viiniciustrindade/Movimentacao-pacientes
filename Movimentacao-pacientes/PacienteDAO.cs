using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_pacientes
{
    public class PacienteDAO
    {
        private SqlConnection Connection { get; }
        public PacienteDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public List<MovModel> GetPacientes()
        {
            List<MovModel> movimentacoes = new List<MovModel>();
            SqlCommand command = Connection.CreateCommand();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT PAC.codPaciente, PAC.nomePaciente, PAC.nomeMaePaciente, PAC.dataNascPaciente, REG.codProntuario, REG.localizacao, REG.leito, REG.centroDeCusto, REG.clinicaMedica, REG.medico, REG.CRM " +
                           "FROM mvtHospCadPac PAC " +
                           "INNER JOIN mvtHospRegInt REG ON PAC.codPaciente = REG.codPaciente " +
                           "WHERE REG.situacao = 'internado' OR REG.situacao = 'transferencia'");
            command.CommandText = sql.ToString();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    movimentacoes.Add(PopulateDr(dr));
                }
            }
            
            return movimentacoes;
        }
        private MovModel PopulateDr(SqlDataReader dr)
        {
            string localizacao = "";
            string leito = "";
            string centroCusto = "";
            string clinicaMedica = "";
            string medico = "";
            string crm = "";

            ProntuarioModel codProntuario = null;

            PacienteModel codPaciente = null;
            PacienteModel nomePaciente = null;
            PacienteModel maePaciente = null;
            PacienteModel dataNasc = null;


            if (DBNull.Value != dr["localizacao"])
            {
                localizacao = dr["localizacao"] + "";
            }
            if (DBNull.Value != dr["leito"])
            {
                leito = dr["leito"] + "";
            }
            if (DBNull.Value != dr["centroDeCusto"])
            {
                centroCusto = dr["centroDeCusto"] + "";
            }
            if (DBNull.Value != dr["clinicaMedica"])
            {
                clinicaMedica = dr["clinicaMedica"] + "";
            }
            if (DBNull.Value != dr["medico"])
            {
                medico = dr["medico"] + "";
            }
            if (DBNull.Value != dr["CRM"])
            {
                crm = dr["CRM"] + "";
            }
            if (DBNull.Value != dr["codProntuario"])
            {
                string prontuario = dr["codProntuario"] + "";
                codProntuario = new ProntuarioModel()
                {
                    codProntuario = prontuario
                };
            }
            if (DBNull.Value != dr["codPaciente"])
            {
                string paciente = dr["codPaciente"] + "";
                codPaciente = new PacienteModel()
                {
                    codPaciente = paciente
                };
            }
            if (DBNull.Value != dr["nomePaciente"])
            {
                string paciente = dr["nomePaciente"] + "";
                nomePaciente = new PacienteModel()
                {
                    nomePaciente = paciente
                };
            }
            if (DBNull.Value != dr["nomeMaePaciente"])
            {
                string paciente = dr["nomeMaePaciente"] + "";
                maePaciente = new PacienteModel()
                {
                    mae = paciente
                };
            }
            if (DBNull.Value != dr["dataNascPaciente"])
            {
                string paciente = dr["dataNascPaciente"] + "";
                dataNasc = new PacienteModel()
                {
                    dataNasc = paciente
                };
            }
            return new MovModel()
            {
                localizacao = localizacao,
                leito = leito,
                centroCusto = centroCusto,
                clinicaMedica = clinicaMedica,
                medico = medico,
                crm = crm,
                ProntuarioModel = codProntuario,
                PacienteModel = codPaciente,
                nomePaciente = nomePaciente,
                maePaciente = maePaciente,
                dataNasc = dataNasc

            };
        }
    }
}
