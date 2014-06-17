using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenis
{
    class jugador
    {
       private int puntos;

        


        public jugador()
        {
             puntos = 0;
        }

        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

    }
}
