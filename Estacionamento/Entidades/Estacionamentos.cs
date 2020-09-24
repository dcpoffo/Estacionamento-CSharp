using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Entidades
{
    class Estacionamentos
    {
        public int Id { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public string Placa { get; set; }
        public double ValorTotal { get; set; }
        public int IdPreco { get; set; }
    }
}
