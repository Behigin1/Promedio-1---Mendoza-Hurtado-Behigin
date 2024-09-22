using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_1___Mendoza_Hurtado_Behigin
{
    public class Jugador
    {
        public int PuntosInteligencia { get; private set; }
        public int PuntosIgnorancia { get; private set; }

        public Jugador()
        {
            PuntosInteligencia = 0;
            PuntosIgnorancia = 0;
        }

        public void Responder(bool esCorrecta)
        {
            if (esCorrecta)
            {
                PuntosInteligencia++;
            }
            else
            {
                PuntosIgnorancia++;
            }
        }
    }
}
