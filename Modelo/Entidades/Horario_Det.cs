using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Horario_Det
    {
        public int DetalleId { get; set; }
        public DateTime Anio { get; set; }
        public DateTime Mes { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public DateTime Minuto { get; set; }
    }
}
