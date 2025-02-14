using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class DatosEx : ApplicationException
    {
        public DatosEx(string mensaje, Exception original)
               : base(mensaje, original)
        {

        }
        public DatosEx(string mensaje)
            : base(mensaje)
        {

        }

    }
}

