namespace Estacionamento.Telas
{
    partial class frmEntradaEstacionamento
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
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarEntrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(13, 87);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.MaxLength = 10;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(132, 26);
            this.txtPlaca.TabIndex = 17;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Placa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpEntrada.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            this.dtpEntrada.Enabled = false;
            this.dtpEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrada.Location = new System.Drawing.Point(13, 33);
            this.dtpEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(196, 26);
            this.dtpEntrada.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Entrada";
            // 
            // btnSalvarEntrada
            // 
            this.btnSalvarEntrada.Location = new System.Drawing.Point(56, 120);
            this.btnSalvarEntrada.Name = "btnSalvarEntrada";
            this.btnSalvarEntrada.Size = new System.Drawing.Size(111, 37);
            this.btnSalvarEntrada.TabIndex = 18;
            this.btnSalvarEntrada.Text = "Salvar Entrada";
            this.btnSalvarEntrada.UseVisualStyleBackColor = true;
            this.btnSalvarEntrada.Click += new System.EventHandler(this.btnSalvarEntrada_Click);
            // 
            // frmEntradaEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 162);
            this.Controls.Add(this.btnSalvarEntrada);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntradaEstacionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Entrada";
            this.Load += new System.EventHandler(this.frmEntradaEstacionamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarEntrada;
    }
}