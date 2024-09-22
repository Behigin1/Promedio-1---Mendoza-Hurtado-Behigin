using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_1___Mendoza_Hurtado_Behigin
{
    public class Pregunta
    {
        public string Texto;
        public string[] Opciones;
        public string RespuestaCorrecta;
        public Pregunta(string texto, string[] opciones, string respuestaCorrecta)
        {
            Texto = texto;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
        }
    }
}
