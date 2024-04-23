using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    internal class Circulo : FiguraGeometrica
    {
        public float Radio { get; set; }

        public override float CalcularArea()
        {
            return (float)(Math.PI * Math.Pow(Radio, 2));
        }

        public override float CalcularPermietro()
        {
            return (float)Math.PI * (Radio * 2);
        }
    }
}
