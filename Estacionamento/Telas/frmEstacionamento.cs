using Estacionamento.Entidades;
using Estacionamento.Model;
using Estacionamento.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Telas
{
    public partial class frmEstacionamento : Form
    {
        EstacionamentoModel model = new EstacionamentoModel();
        public frmEstacionamento()
        {
            InitializeComponent();
        }

        private void frmEstacionamento_Load(object sender, EventArgs e)
        {
            ListarEstacionamentos();
        }

        public void ListarEstacionamentos()
        {
            dgvEstacionamento.DataSource = model.ListarEstacionamentos();

            if (dgvEstacionamento.Rows.Count == 0)
            {
                btnMarcarSaida.Enabled = false;
                return;
            }

            btnMarcarSaida.Enabled = true;
            dgvEstacionamento.ColumnHeadersDefaultCellStyle.Font = new Font(dgvEstacionamento.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgvEstacionamento.Focus();
        }

        public void ListarEstacionamentosPorPlaca()
        {
            string placa = txtplaca.Text;
   
            dgvEstacionamento.DataSource = model.ListarEstacionamentoPorPlaca(placa);

            dgvEstacionamento.ColumnHeadersDefaultCellStyle.Font = new Font(dgvEstacionamento.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgvEstacionamento.Focus();
        }       

        private void btnNova_Click(object sender, EventArgs e)
        {
            frmEntradaEstacionamento entrada = new frmEntradaEstacionamento();
            entrada.ShowDialog();
            if (entrada.DialogResult == DialogResult.OK)
            {
                ListarEstacionamentos();
            }
        }

        private void frmEstacionamento_Activated(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {   
            if (Validar())
            {
                Estacionamentos dados = new Estacionamentos();

                if (RegistrarSaida(dados))
                {
                    ListarEstacionamentos();
                    txtplaca.Clear();
                }
            }
        }

        private bool RegistrarSaida(Estacionamentos dados)
        {
            dados.Id = int.Parse(dgvEstacionamento.CurrentRow.Cells[0].Value.ToString());
            dados.Entrada = DateTime.Parse(dgvEstacionamento.CurrentRow.Cells[2].Value.ToString());
            dados.Saida = DateTime.Now;
            double valorHoraInicial = double.Parse(dgvEstacionamento.CurrentRow.Cells[4].Value.ToString());
            double valorHoraAdicional = double.Parse(dgvEstacionamento.CurrentRow.Cells[5].Value.ToString());
            CalcularValorTotalEstacionamentoServico calculo = new CalcularValorTotalEstacionamentoServico();
            dados.ValorTotal = calculo.CalculoValorTotal(dados.Entrada, dados.Saida, valorHoraInicial, valorHoraAdicional);

            if (model.RegistrarSaida(dados))
            {
                MessageBox.Show("Saida registrada com sucesso!", "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao registrar Saida!", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Validar()
        {
            if (dgvEstacionamento.Rows.Count == 0)
            {
                MessageBox.Show("Não há entradas registradas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtplaca.Focus();
                return false;
            }

            return true;
        }

        public void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            txtplaca.Clear();
            ListarEstacionamentos();
        }

        private void txtplaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarEstacionamentosPorPlaca();
            }
        }

        private void dgvEstacionamento_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstacionamento.CurrentRow.Cells[3].Value.ToString() == "")
            {
                btnMarcarSaida.Enabled = true;
                return;
            }
            btnMarcarSaida.Enabled = false;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar essa Entrada?", "Alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Estacionamentos dados = new Estacionamentos();
            if (Excluir(dados))
            {
                ListarEstacionamentos();
            }
        }

        private bool Excluir(Estacionamentos dado)
        {
            dado.Id = int.Parse(dgvEstacionamento.CurrentRow.Cells[0].Value.ToString());
            if (model.Excluir(dado))
            {
                MessageBox.Show("Estacionamento excluido com sucesso!", "Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Erro ao excluir Estacionamento!", "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return false;
        }
    }
}
