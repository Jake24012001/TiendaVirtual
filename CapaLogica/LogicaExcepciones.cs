﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaExcepciones : ApplicationException
    {
        public LogicaExcepciones(string mensaje, Exception original)
         : base(mensaje, original)
        {

        }
        public LogicaExcepciones(string mensaje)
            : base(mensaje)
        {

        }
    }
}
