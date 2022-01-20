using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Horario_Det
    {
        public int Horario_DetId { get; set; }
        public DateTime Anio { get; set; }
        public DateTime Mes { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public DateTime Minuto { get; set; }
        public Control_Asistencia Control_Asistencia { get; set; }
        public int Control_AsistenciaId { get; set; }
    }
}
