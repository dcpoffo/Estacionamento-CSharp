using Estacionamento.DAO;
using Estacionamento.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Model
{
    class EstacionamentoModel
    {
        EstacionamentoDao dao = new EstacionamentoDao();
        public DataTable ListarEstacionamentoPorPlaca(string placa)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarEstacionamentoPorPlaca(placa);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool RegistrarEntrada(Estacionamentos dado)
        {
            if (dao.RegistrarEntrada(dado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object ListarEstacionamentos()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarEstacionamento();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool PesquisarSeDataDentroDeVigencia(Vigencia vigencia, DateTime data)
        {
            if (dao.PesquisarSeDataDentroDeVigencia(vigencia, data))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RegistrarSaida(Estacionamentos dado)
        {
            if (dao.RegistrarSaida(dado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verificaSePrecoCadastrado(int id)
        {
            if (dao.VerificaSePrecoCadastrado(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Excluir(Estacionamentos dado)
        {
            if (dao.Excluir(dado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PesquisarPorCarroJaEstacionado(string placa)
        {
            if (dao.PesquisarPorCarroJaEstacionado(placa))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
