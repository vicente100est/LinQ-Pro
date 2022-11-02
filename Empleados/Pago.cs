using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Pago
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public bool Procesado { get; set; }
        public int IdExterenoEmpleado { get; set; }
    }
}
