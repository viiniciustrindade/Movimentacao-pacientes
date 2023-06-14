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
        public List<PacienteModel> GetPacientes()
        {
            List<PacienteModel> pacientes = new List<PacienteModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT PAC.codPaciente, PAC.nomePaciente, PAC.nomeMaePaciente, PAC.dataNascPaciente FROM mvtHospCadPac PAC");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        pacientes.Add(PopulateDr(dr));
                    }
                }
            }
            return pacientes;
        }
        private PacienteModel PopulateDr(SqlDataReader dr)
        {
            string codPaciente = "";
            string nomePaciente = "";
            string maePaciente = "";
            string dataNasc = "";

            if (DBNull.Value != dr["codPaciente"])
            {
                codPaciente = dr["codPaciente"] + "";
            }
            if (DBNull.Value != dr["nomePaciente"])
            {
                nomePaciente = dr["nomePaciente"] + "";
            }
            if (DBNull.Value != dr["dataNascPaciente"])
            {
                dataNasc = dr["dataNascPaciente"] + "";
            }
            if (DBNull.Value != dr["nomeMaePaciente"])
            {
                maePaciente = dr["nomeMaePaciente"] + "";
            }

            return new PacienteModel()
            {
                codPaciente = codPaciente,
                nomePaciente = nomePaciente,
                mae = maePaciente,
                dataNasc = dataNasc,

            };
        }
    }
}
