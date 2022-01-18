using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Facturas
    {
        public int FacturaId { get; set; }
        public DateTime Anio { get; set; }
        public DateTime Mes { get; set; }
        public DateTime Dia { get; set; }
        public float Importe { get; set; }
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }
    }
}
