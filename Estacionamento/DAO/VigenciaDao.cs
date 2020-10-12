using Estacionamento.Entidades;
using Estacionamento.Servico;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.DAO
{
    class VigenciaDao
    {

        MySqlCommand sql;

        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select id, vigenciaInicial, vigenciaFinal, valorHoraInicial, valorHoraAdicional from tabelaPreco", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public bool Alterar(Vigencia dado)
        {
            try
            {
                con.AbrirConexao();

                sql = new MySqlCommand("update tabelaPreco set vigenciaInicial = @vigenciaInicial, vigenciaFinal = @vigenciaFinal, " +
                    "valorHoraInicial = @valorHoraInicial, valorHoraAdicional = @valorHoraAdicional " +
                    "where id = @id", con.con);
                sql.Parameters.AddWithValue("id", dado.Id);
                sql.Parameters.AddWithValue("vigenciaInicial", dado.VigenciaInicial);
                sql.Parameters.AddWithValue("vigenciaFinal", dado.VigenciaInicial);
                sql.Parameters.AddWithValue("valorHoraInicial", dado.ValorHoraInicial);
                sql.Parameters.AddWithValue("valorHoraAdicional", dado.ValorHoraAdicional);
                sql.ExecuteNonQuery();
                con.FecharConexao();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro\n" + ex.Message, "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                con.FecharConexao();
                return false;
            }
        }

        public bool Excluir(Vigencia dado)
        {
            try
            {
                con.AbrirConexao();

                sql = new MySqlCommand("delete from tabelaPreco where id = @id", con.con);
                sql.Parameters.AddWithValue("id", dado.Id);
                sql.ExecuteNonQuery();
                con.FecharConexao();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro\n" + ex.Message, "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                con.FecharConexao();
                return false;
            }
        }

        public bool VerificaDataCadastrada(DateTime dataInicial, DateTime dataFinal)
        {
            var _dataInicial= dataInicial.Date;
            var _dataFinal = dataFinal.Date;
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select id, vigenciaInicial, vigenciaFinal from tabelaPreco", con.con);

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    List<Vigencia> vigencias = new List<Vigencia>();
                    while (dr.Read())
                    {
                        vigencias.Add(new Vigencia
                        {
                            Id = dr.GetInt32("id"),
                            VigenciaInicial = dr.GetDateTime("vigenciaInicial"),
                            VigenciaFinal = dr.GetDateTime("vigenciaFinal"),
                        });
                        var inicial = dr.GetDateTime("vigenciaInicial");
                        var final = dr.GetDateTime("vigenciaFinal");

                        if ((_dataInicial >= inicial && (_dataFinal <= final))
                        || ((_dataFinal >= inicial && (_dataFinal <= final)))
                        || (_dataInicial == final) || (_dataFinal <= inicial))
                        {
                            return true;
                        }
                    }
                }
                return false;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public bool Inserir(Vigencia dado)
        {
            try
            {
                con.AbrirConexao();

                sql = new MySqlCommand("insert into tabelaPreco " +
                    "(vigenciaInicial, vigenciaFinal, valorHoraInicial, valorHoraAdicional) " +
                    "values " +
                    "(@vigenciaInicial, @vigenciaFinal, @valorHoraInicial, @valorHoraAdicional)"
                    , con.con);

                sql.Parameters.AddWithValue("vigenciaInicial", dado.VigenciaInicial);
                sql.Parameters.AddWithValue("vigenciaFinal", dado.VigenciaFinal);
                sql.Parameters.AddWithValue("valorHoraInicial", dado.ValorHoraInicial);
                sql.Parameters.AddWithValue("valorHoraAdicional", dado.ValorHoraAdicional);
                sql.ExecuteNonQuery();
                con.FecharConexao();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro\n" + ex.Message, "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                con.FecharConexao();
                return false;
            }
        }

        internal DataTable procurarData()
        {
            throw new NotImplementedException();
        }
    }
}