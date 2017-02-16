using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class entUsuario
    {
        public int idUsuario { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String NombreUsuario { get; set; }
        public String Clave { get; set; }
        public DateTime ValidoHasta{ get; set; }
    }
}
