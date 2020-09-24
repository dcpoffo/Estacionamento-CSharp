using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Entidades
{
    class Vigencia
    {
        public int Id { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFinal { get; set; }
        public double ValorHoraInicial { get; set; }
        public double ValorHoraAdicional { get; set; }
    }
}
