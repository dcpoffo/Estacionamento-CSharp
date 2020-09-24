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

    public partial class frmCadastroDeVigencia : Form
    {
        VigenciaModel model = new VigenciaModel();
        EstacionamentoModel estacionamentoModel = new EstacionamentoModel();
        public bool novo = false;

        public frmCadastroDeVigencia()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabilitaCampos();
            dgvPreco.Enabled = false;
            btnNova.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnApagar.Enabled = false;
            novo = true;
        }

        private void HabilitaCampos()
        {
            dtpVigenciaInicial.Enabled = true;
            dtpVigenciaFinal.Enabled = true;
            txtValorHoraInicial.Enabled = true;
            txtValorHoraAdicional.Enabled = true;
        }

        private void DesabilitaCampos()
        {
            dtpVigenciaInicial.Enabled = false;
            dtpVigenciaFinal.Enabled = false;
            txtValorHoraInicial.Enabled = false;
            txtValorHoraAdicional.Enabled = false;
        }

        private void LimpaCampos()
        {
            dtpVigenciaInicial.Value = DateTime.Now;
            dtpVigenciaFinal.Value = DateTime.Now;
            txtValorHoraInicial.Clear();
            txtValorHoraAdicional.Clear();
        }

        private void frmCadastroDeVigencia_Load(object sender, EventArgs e)
        {
            ListarVigencias();
        }

        private void ListarVigencias()
        {
            dgvPreco.DataSource = model.Listar();

            if (dgvPreco.Rows.Count == 0)
            {
                LimpaCampos();
            }
            else
            {
                PreencheCampos();
            }
            MostraCamposPreco();
            dgvPreco.ColumnHeadersDefaultCellStyle.Font = new Font(dgvPreco.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgvPreco.Focus();
        }

        private void PreencheCampos()
        {
            dtpVigenciaInicial.Value = DateTime.Parse(dgvPreco.CurrentRow.Cells[1].Value.ToString());
            dtpVigenciaFinal.Value = DateTime.Parse(dgvPreco.CurrentRow.Cells[2].Value.ToString());
            txtValorHoraInicial.Text = dgvPreco.CurrentRow.Cells[3].Value.ToString();
            txtValorHoraAdicional.Text = dgvPreco.CurrentRow.Cells[4].Value.ToString();
        }

        private void MostraCamposPreco()
        {
            //campos que aparecem na tabela
            dgvPreco.Columns[0].HeaderText = "I.D.";
            dgvPreco.Columns[1].HeaderText = "Início da Vigência";
            dgvPreco.Columns[2].HeaderText = "Fim da Vigência";
            dgvPreco.Columns[3].HeaderText = "Valor da Hora Inicial";
            dgvPreco.Columns[4].HeaderText = "Valor da Hora Adicional";

            dgvPreco.Columns[0].Width = 50;
            dgvPreco.Columns[1].Width = 110;
            dgvPreco.Columns[2].Width = 110;
            dgvPreco.Columns[3].Width = 100;
            dgvPreco.Columns[4].Width = 100;
            //quem aparece
            dgvPreco.Columns["id"].Visible = false;
            dgvPreco.Columns["vigenciaInicial"].Visible = true;
            dgvPreco.Columns["vigenciaFinal"].Visible = true;
            dgvPreco.Columns["valorHoraInicial"].Visible = true;
            dgvPreco.Columns["valorHoraAdicional"].Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            DesabilitaCampos();
            VerificarBotoes();
            ListarVigencias();
            dgvPreco.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Vigencia dados = new Vigencia();

                if (Salvar(dados))
                {
                    DesabilitaCampos();
                    ListarVigencias();

                    VerificarBotoes();

                    dgvPreco.Enabled = true;
                }
            }
        }

        private bool Validar()
        {
            if (dtpVigenciaFinal.Value < dtpVigenciaInicial.Value)
            {
                MessageBox.Show("A Vigência Final não pode ser menor que a Vigência Inicial!", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpVigenciaFinal.Value = dtpVigenciaInicial.Value;
                return false;
            }

            if (dtpVigenciaInicial.Value < DateTime.Now)
            {
                MessageBox.Show($"Você não pode cadastrar uma Vigência com Data Inicial menor que hoje! ", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpVigenciaFinal.Value = dtpVigenciaInicial.Value;
                return false;
            }

            if (VerificaDataCadastrada(dtpVigenciaInicial.Value, dtpVigenciaFinal.Value))
            {
                MessageBox.Show("Este intervalo já faz parte de uma vigência. Favor verificar!", "ERRO", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(txtValorHoraInicial.Text))
            {
                MessageBox.Show("O valor da Hora Inicial deve ser preenchido!", "ERRO", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                txtValorHoraInicial.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtValorHoraAdicional.Text))
            {
                MessageBox.Show("O valor da Hora Adicional deve ser preenchido!", "ERRO", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                txtValorHoraAdicional.Focus();
                return false;
            }
            return true;
        }

        private bool VerificaDataCadastrada(DateTime dataInicial, DateTime dataFinal)
        {
            if (model.VerificaDataCadastrada(dataInicial, dataFinal))
            {
                return true;
            }
            return false;
        }

        private bool Salvar(Vigencia dado)
        {
            dado.VigenciaInicial = dtpVigenciaInicial.Value;
            dado.VigenciaFinal = dtpVigenciaFinal.Value;
            dado.ValorHoraInicial = double.Parse(txtValorHoraInicial.Text);
            dado.ValorHoraAdicional = double.Parse(txtValorHoraAdicional.Text);

            if (novo)
            {
                if (model.Inserir(dado))
                {
                    MessageBox.Show("Vigência Inclusa com sucesso!", "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Vigência!", "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                dado.Id = int.Parse(dgvPreco.CurrentRow.Cells[0].Value.ToString());

                if (model.Alterar(dado))
                {
                    MessageBox.Show("Parametrização atualizada com sucesso!", "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar Parametrização!", "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void dgvPreco_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            PreencheCampos();
        }

        private void txtValorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((((((((e.KeyChar != (char)Keys.D0) &&
                (e.KeyChar != (char)Keys.D1) &&
                (e.KeyChar != (char)Keys.D2) &&
                (e.KeyChar != (char)Keys.D3) &&
                (e.KeyChar != (char)Keys.D4) &&
                (e.KeyChar != (char)Keys.D5) &&
                (e.KeyChar != (char)Keys.D6) &&
                (e.KeyChar != (char)Keys.D7) &&
                (e.KeyChar != (char)Keys.D8) &&
                (e.KeyChar != (char)Keys.D9) &&
                (e.KeyChar != (char)Keys.Back) &&
                (e.KeyChar != ','))))))))))
            {
                e.Handled = true;
            }
        }

        private void btnApagarAluno_Click(object sender, EventArgs e)
        {
            if (verificaSePrecoCadastrado())
            {
                MessageBox.Show("Esta parametrização não pode ser excluída pois já estar sendo usada em algum estacionamento!", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Deseja realmente apagar essa Parametrização?", "Alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                Vigencia dados = new Vigencia();
                if (Excluir(dados))
                {
                    ListarVigencias();
                    VerificarBotoes();
                }
            }
        }

        private bool verificaSePrecoCadastrado()
        {
            int id = int.Parse(dgvPreco.CurrentRow.Cells[0].Value.ToString());

            if (estacionamentoModel.verificaSePrecoCadastrado(id))
            {
                return true;
            }
            return false;
        }

        private void VerificarBotoes()
        {
            if (dgvPreco.RowCount == 0)
            {
                btnApagar.Enabled = false;
            }
            else
            {
                btnApagar.Enabled = true;
            }
            btnSalvar.Enabled = false;
            btnNova.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private bool Excluir(Vigencia dado)
        {
            dado.Id = int.Parse(dgvPreco.CurrentRow.Cells[0].Value.ToString());
            if (model.Excluir(dado))
            {
                MessageBox.Show("Parametrização excluida com sucesso!", "Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Erro ao excluir Parametrização!", "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            novo = false;
            dgvPreco.Enabled = false;
            btnNova.Enabled = false;
            btnApagar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            HabilitaCampos();
        }

        private void txtValorHoraAdicional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((((((((e.KeyChar != (char)Keys.D0) &&
                (e.KeyChar != (char)Keys.D1) &&
                (e.KeyChar != (char)Keys.D2) &&
                (e.KeyChar != (char)Keys.D3) &&
                (e.KeyChar != (char)Keys.D4) &&
                (e.KeyChar != (char)Keys.D5) &&
                (e.KeyChar != (char)Keys.D6) &&
                (e.KeyChar != (char)Keys.D7) &&
                (e.KeyChar != (char)Keys.D8) &&
                (e.KeyChar != (char)Keys.D9) &&
                (e.KeyChar != (char)Keys.Back) &&
                (e.KeyChar != ','))))))))))
            {
                e.Handled = true;
            }
        }
    }
}
