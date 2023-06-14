namespace Movimentacao_pacientes
{
    partial class BuscarCentroCusto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCentroCusto));
            this.txtCodCentroCusto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCentroDeCusto = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.Label();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodigoCentroCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCentroCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodCentroCusto
            // 
            this.txtCodCentroCusto.Location = new System.Drawing.Point(89, 8);
            this.txtCodCentroCusto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodCentroCusto.Name = "txtCodCentroCusto";
            this.txtCodCentroCusto.Size = new System.Drawing.Size(48, 20);
            this.txtCodCentroCusto.TabIndex = 47;
            this.txtCodCentroCusto.TextChanged += new System.EventHandler(this.txtCodCentroCusto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Código";
            // 
            // txtCentroDeCusto
            // 
            this.txtCentroDeCusto.Location = new System.Drawing.Point(89, 31);
            this.txtCentroDeCusto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCentroDeCusto.Name = "txtCentroDeCusto";
            this.txtCentroDeCusto.Size = new System.Drawing.Size(195, 20);
            this.txtCentroDeCusto.TabIndex = 45;
            this.txtCentroDeCusto.TextChanged += new System.EventHandler(this.txtCentroDeCusto_TextChanged);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.AutoSize = true;
            this.txtNomeAutor.Location = new System.Drawing.Point(9, 33);
            this.txtNomeAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(82, 13);
            this.txtNomeAutor.TabIndex = 44;
            this.txtNomeAutor.Text = "Centro de custo";
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoCentroCusto,
            this.colNomeCentroCusto});
            this.dadosGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid.Location = new System.Drawing.Point(11, 54);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(428, 213);
            this.dadosGrid.TabIndex = 43;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // colCodigoCentroCusto
            // 
            this.colCodigoCentroCusto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodigoCentroCusto.FillWeight = 152.2843F;
            this.colCodigoCentroCusto.HeaderText = "Código";
            this.colCodigoCentroCusto.MinimumWidth = 6;
            this.colCodigoCentroCusto.Name = "colCodigoCentroCusto";
            this.colCodigoCentroCusto.ReadOnly = true;
            this.colCodigoCentroCusto.Width = 65;
            // 
            // colNomeCentroCusto
            // 
            this.colNomeCentroCusto.FillWeight = 73.85786F;
            this.colNomeCentroCusto.HeaderText = "Centro de custo";
            this.colNomeCentroCusto.MinimumWidth = 6;
            this.colNomeCentroCusto.Name = "colNomeCentroCusto";
            this.colNomeCentroCusto.ReadOnly = true;
            // 
            // BuscarCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 275);
            this.Controls.Add(this.txtCodCentroCusto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCentroDeCusto);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.dadosGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarCentroCusto";
            this.Text = "Buscar Centro de Custo";
            this.Load += new System.EventHandler(this.BuscarCentroCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodCentroCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCentroDeCusto;
        private System.Windows.Forms.Label txtNomeAutor;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoCentroCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCentroCusto;
    }
}