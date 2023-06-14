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
    public partial class BuscarCentroCusto : Form
    {
        public BuscarCentroCusto()
        {
            InitializeComponent();
        }
        public string nomeCentroCusto { get; private set; }
        public void FecharFormulario()
        {
            nomeCentroCusto = txtCentroDeCusto.Text;

            this.Close();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                CentroCustoDAO dao = new CentroCustoDAO(connection);
                List<CentroCustoModel> centros = dao.GetCentros();
                foreach (CentroCustoModel centro in centros)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colCodigoCentroCusto.Index].Value = centro.codCentroCusto;
                    row.Cells[colNomeCentroCusto.Index].Value = centro.nomeCentroCusto;
                }
            }
        }

        private void BuscarCentroCusto_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
        }

        private void txtCentroDeCusto_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtCentroDeCusto.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string nomeAutor = row.Cells[colNomeCentroCusto.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtCodCentroCusto_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtCodCentroCusto.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string nomeAutor = row.Cells[colCodigoCentroCusto.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodCentroCusto.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodigoCentroCusto.Index].Value + "";
                txtCentroDeCusto.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomeCentroCusto.Index].Value + "";

                FecharFormulario();
            }
        }
    }
}
