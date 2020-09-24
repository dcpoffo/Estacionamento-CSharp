namespace Estacionamento.Telas
{
    partial class frmCadastroDeVigencia
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDeVigencia));
            this.dgvPreco = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpVigenciaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpVigenciaFinal = new System.Windows.Forms.DateTimePicker();
            this.Dica = new System.Windows.Forms.ToolTip(this.components);
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnNova = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorHoraInicial = new System.Windows.Forms.TextBox();
            this.txtValorHoraAdicional = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreco
            // 
            this.dgvPreco.AllowUserToAddRows = false;
            this.dgvPreco.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPreco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreco.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPreco.Location = new System.Drawing.Point(0, 127);
            this.dgvPreco.Name = "dgvPreco";
            this.dgvPreco.ReadOnly = true;
            this.dgvPreco.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPreco.Size = new System.Drawing.Size(494, 185);
            this.dgvPreco.TabIndex = 0;
            this.dgvPreco.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreco_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vigência Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vigência Final";
            // 
            // dtpVigenciaInicial
            // 
            this.dtpVigenciaInicial.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpVigenciaInicial.CustomFormat = "";
            this.dtpVigenciaInicial.Enabled = false;
            this.dtpVigenciaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigenciaInicial.Location = new System.Drawing.Point(9, 25);
            this.dtpVigenciaInicial.Name = "dtpVigenciaInicial";
            this.dtpVigenciaInicial.Size = new System.Drawing.Size(105, 20);
            this.dtpVigenciaInicial.TabIndex = 3;
            this.dtpVigenciaInicial.Value = new System.DateTime(2020, 1, 1, 10, 37, 0, 0);
            // 
            // dtpVigenciaFinal
            // 
            this.dtpVigenciaFinal.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpVigenciaFinal.CustomFormat = "";
            this.dtpVigenciaFinal.Enabled = false;
            this.dtpVigenciaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigenciaFinal.Location = new System.Drawing.Point(129, 25);
            this.dtpVigenciaFinal.Name = "dtpVigenciaFinal";
            this.dtpVigenciaFinal.Size = new System.Drawing.Size(105, 20);
            this.dtpVigenciaFinal.TabIndex = 4;
            this.dtpVigenciaFinal.Value = new System.DateTime(2020, 2, 1, 10, 37, 0, 0);
            // 
            // Dica
            // 
            this.Dica.AutoPopDelay = 5000;
            this.Dica.InitialDelay = 300;
            this.Dica.IsBalloon = true;
            this.Dica.ReshowDelay = 100;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.Location = new System.Drawing.Point(44, 90);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(32, 32);
            this.btnApagar.TabIndex = 42;
            this.Dica.SetToolTip(this.btnApagar, "Apagar vigência atual");
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagarAluno_Click);
            // 
            // btnNova
            // 
            this.btnNova.FlatAppearance.BorderSize = 0;
            this.btnNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNova.Image = ((System.Drawing.Image)(resources.GetObject("btnNova.Image")));
            this.btnNova.Location = new System.Drawing.Point(9, 90);
            this.btnNova.Margin = new System.Windows.Forms.Padding(0);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(35, 35);
            this.btnNova.TabIndex = 38;
            this.Dica.SetToolTip(this.btnNova, "Nova Vigência");
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Valor Hora Inicial";
            // 
            // txtValorHoraInicial
            // 
            this.txtValorHoraInicial.Enabled = false;
            this.txtValorHoraInicial.Location = new System.Drawing.Point(9, 67);
            this.txtValorHoraInicial.Name = "txtValorHoraInicial";
            this.txtValorHoraInicial.Size = new System.Drawing.Size(83, 20);
            this.txtValorHoraInicial.TabIndex = 41;
            this.txtValorHoraInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorHora_KeyPress);
            // 
            // txtValorHoraAdicional
            // 
            this.txtValorHoraAdicional.Enabled = false;
            this.txtValorHoraAdicional.Location = new System.Drawing.Point(126, 67);
            this.txtValorHoraAdicional.Name = "txtValorHoraAdicional";
            this.txtValorHoraAdicional.Size = new System.Drawing.Size(83, 20);
            this.txtValorHoraAdicional.TabIndex = 45;
            this.txtValorHoraAdicional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorHoraAdicional_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Valor Hora Adicional";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(76, 90);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(35, 35);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(111, 90);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(35, 35);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastroDeVigencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 312);
            this.Controls.Add(this.txtValorHoraAdicional);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.txtValorHoraInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpVigenciaFinal);
            this.Controls.Add(this.dtpVigenciaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPreco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroDeVigencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Vigência";
            this.Load += new System.EventHandler(this.frmCadastroDeVigencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpVigenciaInicial;
        private System.Windows.Forms.DateTimePicker dtpVigenciaFinal;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ToolTip Dica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorHoraInicial;
        public System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtValorHoraAdicional;
        private System.Windows.Forms.Label label4;
    }
}