using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    abstract class FiguraGeometrica
    {
        public virtual float CalcularArea() { return 0; }
        public virtual float CalcularPermietro() { return 0; }

    }
}
