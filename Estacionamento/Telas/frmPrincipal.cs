using Estacionamento.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void vigênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDeVigencia vigencia = new frmCadastroDeVigencia();
            vigencia.Show();
        }

        private void estacionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstacionamento estacionamento = new frmEstacionamento();
            estacionamento.Show();
        }
    }
}
