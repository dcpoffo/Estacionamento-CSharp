namespace Estacionamento.Telas
{
    partial class frmEstacionamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEstacionamento = new System.Windows.Forms.DataGridView();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dica = new System.Windows.Forms.ToolTip(this.components);
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.btnMarcarEntrada = new System.Windows.Forms.Button();
            this.btnMarcarSaida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstacionamento
            // 
            this.dgvEstacionamento.AllowUserToAddRows = false;
            this.dgvEstacionamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEstacionamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEstacionamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstacionamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstacionamento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstacionamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEstacionamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstacionamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEstacionamento.Location = new System.Drawing.Point(0, 69);
            this.dgvEstacionamento.MultiSelect = false;
            this.dgvEstacionamento.Name = "dgvEstacionamento";
            this.dgvEstacionamento.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEstacionamento.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEstacionamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstacionamento.Size = new System.Drawing.Size(819, 437);
            this.dgvEstacionamento.TabIndex = 0;
            this.dgvEstacionamento.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstacionamento_CellEnter);
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaca.Location = new System.Drawing.Point(12, 31);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(122, 29);
            this.txtplaca.TabIndex = 44;
            this.Dica.SetToolTip(this.txtplaca, "Localiza placa somente se a Data de Saida estiver em branco");
            this.txtplaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtplaca_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Localizar Placa (Enter para localizar)";
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
            this.btnApagar.Image = global::Estacionamento.Properties.Resources.delete;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApagar.Location = new System.Drawing.Point(510, 5);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(100, 57);
            this.btnApagar.TabIndex = 47;
            this.btnApagar.Text = "Excluir Estacionamento";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dica.SetToolTip(this.btnApagar, "Apagar vigência atual");
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Image = global::Estacionamento.Properties.Resources.filteroff;
            this.btnLimparFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparFiltro.Location = new System.Drawing.Point(140, 29);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(96, 33);
            this.btnLimparFiltro.TabIndex = 46;
            this.btnLimparFiltro.Text = "Limpar Filtro";
            this.btnLimparFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dica.SetToolTip(this.btnLimparFiltro, "Limpar Filtro");
            this.btnLimparFiltro.UseVisualStyleBackColor = true;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // btnMarcarEntrada
            // 
            this.btnMarcarEntrada.FlatAppearance.BorderSize = 0;
            this.btnMarcarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarEntrada.Image = global::Estacionamento.Properties.Resources.open;
            this.btnMarcarEntrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarcarEntrada.Location = new System.Drawing.Point(610, 5);
            this.btnMarcarEntrada.Margin = new System.Windows.Forms.Padding(0);
            this.btnMarcarEntrada.Name = "btnMarcarEntrada";
            this.btnMarcarEntrada.Size = new System.Drawing.Size(100, 57);
            this.btnMarcarEntrada.TabIndex = 42;
            this.btnMarcarEntrada.Text = "Marcar Entrada";
            this.btnMarcarEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcarEntrada.UseVisualStyleBackColor = true;
            this.btnMarcarEntrada.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // btnMarcarSaida
            // 
            this.btnMarcarSaida.FlatAppearance.BorderSize = 0;
            this.btnMarcarSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarSaida.Image = global::Estacionamento.Properties.Resources.closed;
            this.btnMarcarSaida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarcarSaida.Location = new System.Drawing.Point(710, 5);
            this.btnMarcarSaida.Margin = new System.Windows.Forms.Padding(0);
            this.btnMarcarSaida.Name = "btnMarcarSaida";
            this.btnMarcarSaida.Size = new System.Drawing.Size(100, 57);
            this.btnMarcarSaida.TabIndex = 41;
            this.btnMarcarSaida.Text = "Marcar Saída";
            this.btnMarcarSaida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcarSaida.UseVisualStyleBackColor = true;
            this.btnMarcarSaida.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 506);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnLimparFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.btnMarcarEntrada);
            this.Controls.Add(this.btnMarcarSaida);
            this.Controls.Add(this.dgvEstacionamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmEstacionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas/Saídas";
            this.Activated += new System.EventHandler(this.frmEstacionamento_Activated);
            this.Load += new System.EventHandler(this.frmEstacionamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMarcarEntrada;
        private System.Windows.Forms.Button btnMarcarSaida;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnLimparFiltro;
        public System.Windows.Forms.DataGridView dgvEstacionamento;
        public System.Windows.Forms.ToolTip Dica;
        public System.Windows.Forms.Button btnApagar;
    }
}