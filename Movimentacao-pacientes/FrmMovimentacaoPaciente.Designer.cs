namespace Movimentacao_pacientes
{
    partial class FrmMovimentacaoPaciente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimentacaoPaciente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.txtCodProntuario = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtCodSequencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMotivo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtLeito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCentroCusto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClinicaMedica = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblExibirIdade = new System.Windows.Forms.Label();
            this.lblExibirMae = new System.Windows.Forms.Label();
            this.btnCarregarCentroCusto = new System.Windows.Forms.Button();
            this.btnCarregarPaciente = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prontuário";
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Location = new System.Drawing.Point(82, 12);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.ReadOnly = true;
            this.txtCodPaciente.Size = new System.Drawing.Size(44, 20);
            this.txtCodPaciente.TabIndex = 2;
            // 
            // txtCodProntuario
            // 
            this.txtCodProntuario.Location = new System.Drawing.Point(82, 38);
            this.txtCodProntuario.Name = "txtCodProntuario";
            this.txtCodProntuario.ReadOnly = true;
            this.txtCodProntuario.Size = new System.Drawing.Size(44, 20);
            this.txtCodProntuario.TabIndex = 3;
            this.txtCodProntuario.TextChanged += new System.EventHandler(this.txtCodProntuario_TextChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(82, 90);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(115, 20);
            this.dtpData.TabIndex = 4;
            this.dtpData.Value = new System.DateTime(2023, 6, 16, 0, 0, 0, 0);
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // txtCodSequencia
            // 
            this.txtCodSequencia.Location = new System.Drawing.Point(82, 64);
            this.txtCodSequencia.Name = "txtCodSequencia";
            this.txtCodSequencia.ReadOnly = true;
            this.txtCodSequencia.Size = new System.Drawing.Size(44, 20);
            this.txtCodSequencia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sequência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(82, 116);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(115, 20);
            this.dtpHora.TabIndex = 8;
            this.dtpHora.Value = new System.DateTime(2023, 6, 14, 0, 0, 0, 0);
           // this.dtpHora.ValueChanged += new System.EventHandler(this.dtpHora_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Motivo";
            // 
            // cbxMotivo
            // 
            this.cbxMotivo.FormattingEnabled = true;
            this.cbxMotivo.Items.AddRange(new object[] {
            "Transferência",
            "Óbito",
            "Alta",
            "Evasão"});
            this.cbxMotivo.Location = new System.Drawing.Point(82, 142);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Size = new System.Drawing.Size(115, 21);
            this.cbxMotivo.TabIndex = 11;
            this.cbxMotivo.SelectedIndexChanged += new System.EventHandler(this.cbxMotivo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Localização";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(82, 169);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(115, 20);
            this.txtLocalizacao.TabIndex = 13;
            // 
            // txtLeito
            // 
            this.txtLeito.Location = new System.Drawing.Point(82, 195);
            this.txtLeito.Name = "txtLeito";
            this.txtLeito.Size = new System.Drawing.Size(115, 20);
            this.txtLeito.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Leito";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Centro de custo";
            // 
            // txtCentroCusto
            // 
            this.txtCentroCusto.Location = new System.Drawing.Point(289, 117);
            this.txtCentroCusto.Name = "txtCentroCusto";
            this.txtCentroCusto.ReadOnly = true;
            this.txtCentroCusto.Size = new System.Drawing.Size(115, 20);
            this.txtCentroCusto.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Clinica médica";
            // 
            // txtClinicaMedica
            // 
            this.txtClinicaMedica.Location = new System.Drawing.Point(289, 143);
            this.txtClinicaMedica.Name = "txtClinicaMedica";
            this.txtClinicaMedica.Size = new System.Drawing.Size(144, 20);
            this.txtClinicaMedica.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Médico";
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(289, 169);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(144, 20);
            this.txtMedico.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "CRM";
            // 
            // txtCrm
            // 
            this.txtCrm.Location = new System.Drawing.Point(289, 195);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(144, 20);
            this.txtCrm.TabIndex = 23;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(289, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(68, 23);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(160, 15);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(35, 13);
            this.lblNomePaciente.TabIndex = 35;
            this.lblNomePaciente.Text = "Nome";
            this.lblNomePaciente.Visible = false;
            // 
            // lblExibirIdade
            // 
            this.lblExibirIdade.AutoSize = true;
            this.lblExibirIdade.Location = new System.Drawing.Point(160, 41);
            this.lblExibirIdade.Name = "lblExibirIdade";
            this.lblExibirIdade.Size = new System.Drawing.Size(34, 13);
            this.lblExibirIdade.TabIndex = 36;
            this.lblExibirIdade.Text = "Idade";
            this.lblExibirIdade.Visible = false;
            // 
            // lblExibirMae
            // 
            this.lblExibirMae.AutoSize = true;
            this.lblExibirMae.Location = new System.Drawing.Point(160, 67);
            this.lblExibirMae.Name = "lblExibirMae";
            this.lblExibirMae.Size = new System.Drawing.Size(28, 13);
            this.lblExibirMae.TabIndex = 37;
            this.lblExibirMae.Text = "Mãe";
            this.lblExibirMae.Visible = false;
            // 
            // btnCarregarCentroCusto
            // 
            this.btnCarregarCentroCusto.FlatAppearance.BorderSize = 0;
            this.btnCarregarCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarCentroCusto.Image = global::Movimentacao_pacientes.Properties.Resources.magnifying_glass_icon;
            this.btnCarregarCentroCusto.Location = new System.Drawing.Point(409, 117);
            this.btnCarregarCentroCusto.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarregarCentroCusto.Name = "btnCarregarCentroCusto";
            this.btnCarregarCentroCusto.Size = new System.Drawing.Size(24, 20);
            this.btnCarregarCentroCusto.TabIndex = 34;
            this.btnCarregarCentroCusto.UseVisualStyleBackColor = true;
            this.btnCarregarCentroCusto.Click += new System.EventHandler(this.btnCarregarCentroCusto_Click);
            // 
            // btnCarregarPaciente
            // 
            this.btnCarregarPaciente.FlatAppearance.BorderSize = 0;
            this.btnCarregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarPaciente.Image = global::Movimentacao_pacientes.Properties.Resources.magnifying_glass_icon;
            this.btnCarregarPaciente.Location = new System.Drawing.Point(131, 12);
            this.btnCarregarPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarregarPaciente.Name = "btnCarregarPaciente";
            this.btnCarregarPaciente.Size = new System.Drawing.Size(24, 20);
            this.btnCarregarPaciente.TabIndex = 33;
            this.btnCarregarPaciente.UseVisualStyleBackColor = true;
            this.btnCarregarPaciente.Click += new System.EventHandler(this.btnCarregarPaciente_Click);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(362, 219);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(70, 23);
            this.Novo.TabIndex = 38;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // FrmMovimentacaoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 255);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.lblExibirMae);
            this.Controls.Add(this.lblExibirIdade);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.btnCarregarCentroCusto);
            this.Controls.Add(this.btnCarregarPaciente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtClinicaMedica);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCentroCusto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLeito);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxMotivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodSequencia);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtCodProntuario);
            this.Controls.Add(this.txtCodPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMovimentacaoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação de Paciente";
            this.Load += new System.EventHandler(this.FrmMovimentacaoPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodPaciente;
        private System.Windows.Forms.TextBox txtCodProntuario;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtCodSequencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMotivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.TextBox txtLeito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCentroCusto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClinicaMedica;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregarPaciente;
        private System.Windows.Forms.Button btnCarregarCentroCusto;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblExibirIdade;
        private System.Windows.Forms.Label lblExibirMae;
        private System.Windows.Forms.Button Novo;
    }
}

