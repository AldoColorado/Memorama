using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorama
{
    public class Mensaje
    {
        public DateTime horaDeEnvio { get; set; }
        public string desdeIdUsuario { get; set; }
        public string paraIdUsuario { get; set; }
        public string mensaje { get; set; }
    }
}
