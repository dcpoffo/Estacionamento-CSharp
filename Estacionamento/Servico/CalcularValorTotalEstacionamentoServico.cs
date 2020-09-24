using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Servico
{
    public class CalcularValorTotalEstacionamentoServico
    {
        public double valorTotalEstacionamento = 0;

        //public TimeSpan tempo;
        public double CalculoValorTotal(DateTime entrada, DateTime saida, double valorHoraInicial, double valorHoraAdicional)
        {
            TimeSpan tempoCobrado = saida - entrada;
                           
            int quantidadeHoras = tempoCobrado.Hours;
            int quantidadeMinutos = tempoCobrado.Minutes;

            if (quantidadeHoras == 0 && quantidadeMinutos <= 30)
            {
                valorTotalEstacionamento = valorHoraInicial/2;
            }
            else
            if ((quantidadeHoras == 0 && quantidadeMinutos < 60) || (quantidadeHoras == 1 && quantidadeMinutos <= 10))
            {
                valorTotalEstacionamento = valorHoraInicial;
            }
            else
            {
                if (quantidadeMinutos <= 10)
                {
                    valorTotalEstacionamento = valorHoraInicial + ((quantidadeHoras - 1) * valorHoraAdicional);
                }
                valorTotalEstacionamento = valorHoraInicial + ((quantidadeHoras - 1) * valorHoraAdicional) + valorHoraAdicional;
            }

            MessageBox.Show(                
                $"\nValor da Hora Inicial: R$ {valorHoraInicial.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nValor da Hora Adicional: R$ {valorHoraAdicional.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"\nValor total do Estacionamento: R$ {valorTotalEstacionamento.ToString("F2", CultureInfo.InvariantCulture)}",
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            return valorTotalEstacionamento;
        }
    }
}