using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_pacientes
{
    public class CentroCustoDAO
    {
        private SqlConnection Connection { get; }
        public CentroCustoDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public List<CentroCustoModel> GetCentros()
        {
            List<CentroCustoModel> centros = new List<CentroCustoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT CEN.codCentroCusto, CEN.nomeCentroCusto FROM mvtCadCentroCusto CEN");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        centros.Add(PopulateDr(dr));
                    }
                }
            }
            return centros;
        }
        private CentroCustoModel PopulateDr(SqlDataReader dr)
        {
            string codCentroCusto = "";
            string nomeCentroCusto = "";

            if (DBNull.Value != dr["codCentroCusto"])
            {
                codCentroCusto = dr["codCentroCusto"] + "";
            }
            if (DBNull.Value != dr["nomeCentroCusto"])
            {
                nomeCentroCusto = dr["nomeCentroCusto"] + "";
            }

            return new CentroCustoModel()
            {
                codCentroCusto = codCentroCusto,
                nomeCentroCusto = nomeCentroCusto,

            };
        }
    }
}
