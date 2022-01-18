using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Control_Asistencia
    {
        public int ControlId { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime SalidaAlmuerzo { get; set; }
        public DateTime EntradaAlmuerzo { get; set; }
        public DateTime Salida { get; set; }
        public string Permiso { get; set; }

        public Horario_Det Horario_Detalle{ get; set; }
        public int DetalleId { get; set; }
    }
}
