using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    class Conexao
    {
        string conexao = "Server=localhost;Database=estaciona;Uid=root;Pwd=;";
        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados." +
                    "\nERRO\n" + ex.Message,
                    "Erro de conexão",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado!." +
                       "\nERRO\n" + ex.Message,
                       "Erro de conexão",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
