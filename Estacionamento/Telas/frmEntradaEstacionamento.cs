using Estacionamento.Entidades;
using Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Telas
{
    public partial class frmEntradaEstacionamento : Form
    {
        EstacionamentoModel model = new EstacionamentoModel();
        Vigencia vigencia = new Vigencia();

        public frmEntradaEstacionamento()
        {
            InitializeComponent();
        }
        private void LimpaCampos()
        {
            dtpEntrada.Value = DateTime.Now;
            txtPlaca.Clear();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmEntradaEstacionamento_Load(object sender, EventArgs e)
        {
            dtpEntrada.Value = DateTime.Now;
            txtPlaca.Focus();
        }

        private void btnSalvarEntrada_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Estacionamentos dados = new Estacionamentos();

                if (Salvar(dados))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private bool Validar()
        {
            if (String.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("A placa do veículo deve ser informada!", "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
            }

            if (!PesquisarPorCarroJaEstacionado())
            {
                return false;
            }

            if (!PesquisarSeDataDentroDeVigencia())
            {
                return false;
            }

            return true;
        }

        private bool PesquisarPorCarroJaEstacionado()
        {
            string placa = txtPlaca.Text;

            if (model.PesquisarPorCarroJaEstacionado(placa))
            {
                MessageBox.Show("Parece que este automóvel ainda está no estacionamento", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;                
            }
            else
            {
                return true;
            }
        }

        private bool PesquisarSeDataDentroDeVigencia()
        {
            if (model.PesquisarSeDataDentroDeVigencia(vigencia, dtpEntrada.Value))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Não existe Vigência compatível com essa data de Entrada", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Salvar(Estacionamentos dado)
        {
            dado.Entrada = dtpEntrada.Value;
            dado.Placa = txtPlaca.Text;
            //dado.IdPreco = int.Parse(textBox1.Text);
            dado.IdPreco = vigencia.Id;


            if (model.RegistrarEntrada(dado))
            {
                MessageBox.Show("Entrada registrada com sucesso!", "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao registrar entrada!", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
