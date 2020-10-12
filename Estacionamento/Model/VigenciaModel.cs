using Estacionamento.DAO;
using Estacionamento.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Model
{
    class VigenciaModel
    {
        VigenciaDao dao = new VigenciaDao();
        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Inserir(Vigencia dado)
        {
            if (dao.Inserir(dado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificaDataCadastrada(DateTime dataInicial, DateTime dataFinal)
        {
            if (dao.VerificaDataCadastrada(dataInicial, dataFinal))
            {
                return true;
            }
            return false;
        }

        public bool Excluir(Vigencia dado)
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

        public bool Alterar(Vigencia dado)
        {
            if (dao.Alterar(dado))
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
