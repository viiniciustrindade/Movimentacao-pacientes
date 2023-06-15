namespace Movimentacao_pacientes
{
    partial class SelecionarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarPaciente));
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtcodPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.Label();
            this.dadosGrid4 = new System.Windows.Forms.DataGridView();
            this.colCodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCentroCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClinicaMedica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodProntuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Data de nascimento";
            this.label3.Visible = false;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Enabled = false;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(344, 8);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(105, 20);
            this.dtpDataNascimento.TabIndex = 60;
            this.dtpDataNascimento.Visible = false;
            this.dtpDataNascimento.ValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // txtcodPaciente
            // 
            this.txtcodPaciente.Location = new System.Drawing.Point(75, 11);
            this.txtcodPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodPaciente.Name = "txtcodPaciente";
            this.txtcodPaciente.Size = new System.Drawing.Size(48, 20);
            this.txtcodPaciente.TabIndex = 57;
            this.txtcodPaciente.TextChanged += new System.EventHandler(this.txtcodPaciente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Código";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(75, 34);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(298, 20);
            this.txtNomePaciente.TabIndex = 55;
            this.txtNomePaciente.TextChanged += new System.EventHandler(this.txtNomePaciente_TextChanged);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.AutoSize = true;
            this.txtNomeAutor.Location = new System.Drawing.Point(12, 37);
            this.txtNomeAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(35, 13);
            this.txtNomeAutor.TabIndex = 54;
            this.txtNomeAutor.Text = "Nome";
            // 
            // dadosGrid4
            // 
            this.dadosGrid4.AllowUserToAddRows = false;
            this.dadosGrid4.AllowUserToDeleteRows = false;
            this.dadosGrid4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoPaciente,
            this.colNomePaciente,
            this.colMaePaciente,
            this.colDataNasc,
            this.colLocalizacao,
            this.colLeito,
            this.colCentroCusto,
            this.colClinicaMedica,
            this.colMedico,
            this.colCrm,
            this.colCodProntuario});
            this.dadosGrid4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid4.Location = new System.Drawing.Point(14, 58);
            this.dadosGrid4.Margin = new System.Windows.Forms.Padding(2);
            this.dadosGrid4.Name = "dadosGrid4";
            this.dadosGrid4.ReadOnly = true;
            this.dadosGrid4.RowHeadersWidth = 51;
            this.dadosGrid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid4.Size = new System.Drawing.Size(359, 125);
            this.dadosGrid4.TabIndex = 53;
            this.dadosGrid4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid4_CellDoubleClick);
            // 
            // colCodigoPaciente
            // 
            this.colCodigoPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodigoPaciente.FillWeight = 152.2843F;
            this.colCodigoPaciente.HeaderText = "Código paciente";
            this.colCodigoPaciente.MinimumWidth = 6;
            this.colCodigoPaciente.Name = "colCodigoPaciente";
            this.colCodigoPaciente.ReadOnly = true;
            // 
            // colNomePaciente
            // 
            this.colNomePaciente.FillWeight = 73.85786F;
            this.colNomePaciente.HeaderText = "Nome";
            this.colNomePaciente.MinimumWidth = 6;
            this.colNomePaciente.Name = "colNomePaciente";
            this.colNomePaciente.ReadOnly = true;
            // 
            // colMaePaciente
            // 
            this.colMaePaciente.HeaderText = "Mãe";
            this.colMaePaciente.Name = "colMaePaciente";
            this.colMaePaciente.ReadOnly = true;
            // 
            // colDataNasc
            // 
            this.colDataNasc.HeaderText = "DataNascimento";
            this.colDataNasc.Name = "colDataNasc";
            this.colDataNasc.ReadOnly = true;
            this.colDataNasc.Visible = false;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localização";
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            this.colLocalizacao.Visible = false;
            // 
            // colLeito
            // 
            this.colLeito.HeaderText = "Leito";
            this.colLeito.Name = "colLeito";
            this.colLeito.ReadOnly = true;
            this.colLeito.Visible = false;
            // 
            // colCentroCusto
            // 
            this.colCentroCusto.HeaderText = "Centro de custo";
            this.colCentroCusto.Name = "colCentroCusto";
            this.colCentroCusto.ReadOnly = true;
            this.colCentroCusto.Visible = false;
            // 
            // colClinicaMedica
            // 
            this.colClinicaMedica.HeaderText = "Clinica Médica";
            this.colClinicaMedica.Name = "colClinicaMedica";
            this.colClinicaMedica.ReadOnly = true;
            this.colClinicaMedica.Visible = false;
            // 
            // colMedico
            // 
            this.colMedico.HeaderText = "Médico";
            this.colMedico.Name = "colMedico";
            this.colMedico.ReadOnly = true;
            this.colMedico.Visible = false;
            // 
            // colCrm
            // 
            this.colCrm.HeaderText = "Crm";
            this.colCrm.Name = "colCrm";
            this.colCrm.ReadOnly = true;
            this.colCrm.Visible = false;
            // 
            // colCodProntuario
            // 
            this.colCodProntuario.HeaderText = "Código prontuario";
            this.colCodProntuario.Name = "colCodProntuario";
            this.colCodProntuario.ReadOnly = true;
            this.colCodProntuario.Visible = false;
            // 
            // SelecionarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtcodPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.dadosGrid4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelecionarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Paciente";
            this.Load += new System.EventHandler(this.SelecionarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtcodPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label txtNomeAutor;
        private System.Windows.Forms.DataGridView dadosGrid4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCentroCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClinicaMedica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProntuario;
    }
}