using Estacionamento.Entidades;
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
    class EstacionamentoDao
    {

        MySqlCommand sql;

        Conexao con = new Conexao();
        public DataTable ListarEstacionamentoPorPlaca(string placa)
        {
            try
            {
                con.AbrirConexao();
                {
                    sql = new MySqlCommand("" +
                        "select e.id as '#', e.placa as 'Placa', e.entrada as 'Dt. Entrada', e.saida as 'Dt. Saida', " +
                        "p.valorHoraInicial as 'Valor Hr. Inicial', p.valorHoraAdicional as 'Valor Hr. Adic.', " +
                        "timediff(e.saida,e.entrada) as 'Tempo cobrado', " +
                        "e.valorTotal as 'Total a Pagar' from estacionamento as e " +
                        "inner join tabelaPreco as p on p.id = e.idPreco where e.placa like @placa", con.con);
                    sql.Parameters.AddWithValue("@placa", placa);
                }

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

        public DataTable ListarEstacionamento()
        {
            try
            {
                con.AbrirConexao();
                {
                    sql = new MySqlCommand("" +
                        "select e.id as '#', e.placa as 'Placa', e.entrada as 'Dt. Entrada', e.saida as 'Dt. Saida', " +
                        "p.valorHoraInicial as 'Valor Hr. Inicial', p.valorHoraAdicional as 'Valor Hr. Adic.', " +
                        "timediff(e.saida,e.entrada) as 'Tempo cobrado', " +
                        "e.valorTotal as 'Total a Pagar' from estacionamento as e " +
                        "inner join tabelaPreco as p on p.id = e.idPreco where placa is not null", con.con);
                }

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

        public bool PesquisarPorCarroJaEstacionado(string placa)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select id from estacionamento where placa like @placa and saida is null", con.con);
                sql.Parameters.AddWithValue("@placa", placa);

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public bool Excluir(Estacionamentos dado)
        {
            try
            {
                con.AbrirConexao();

                sql = new MySqlCommand("delete from estacionamento where id = @id", con.con);
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

        public bool VerificaSePrecoCadastrado(int id)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select id from estacionamento where idPreco = @idPreco", con.con);
                sql.Parameters.AddWithValue("@idPreco", id);

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public bool RegistrarSaida(Estacionamentos dado)
        {
            try
            {
                con.AbrirConexao();

                sql = new MySqlCommand("update estacionamento set " +
                    "saida = @saida, " +
                    "valorTotal = @valorTotal " +
                    " where id = @id ", con.con);

                sql.Parameters.AddWithValue("saida", dado.Saida);
                sql.Parameters.AddWithValue("valorTotal", dado.ValorTotal);
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

        public bool RegistrarEntrada(Estacionamentos dado)
        {
            try
            {
                con.AbrirConexao();

                sql = new MySqlCommand("insert into estacionamento " +
                    "(entrada, placa, idPreco) " +
                    "values " +
                    "(@entrada, @placa, @idPreco)"
                    , con.con);

                sql.Parameters.AddWithValue("entrada", dado.Entrada);
                sql.Parameters.AddWithValue("placa", dado.Placa);
                sql.Parameters.AddWithValue("idPreco", dado.IdPreco);
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

        public bool PesquisarSeDataDentroDeVigencia(Vigencia vigencia, DateTime _data)
        {
            var data = _data.Date;
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select * from tabelaPreco", con.con);

                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                if (dr.HasRows)
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
                                ValorHoraInicial = dr.GetDouble("valorHoraInicial"),
                                ValorHoraAdicional = dr.GetDouble("valorHoraAdicional")
                            });

                            if (data >= dr.GetDateTime("vigenciaInicial") && (data <= dr.GetDateTime("vigenciaFinal")))
                            {
                                vigencia.Id = int.Parse(dr["id"].ToString());
                                vigencia.ValorHoraInicial = double.Parse(dr["valorHoraInicial"].ToString());
                                vigencia.ValorHoraAdicional = double.Parse(dr["valorHoraAdicional"].ToString());
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
    }
}
