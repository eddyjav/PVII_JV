using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Sueldo
    {
        public int SueldoId { get; set; }
        public float SueldoBase { get; set; }
        public Cargo CargoS { get; set; }
        public int CargoId { get; set; }
        public Bonos BonosS { get; set; }
    }
}
