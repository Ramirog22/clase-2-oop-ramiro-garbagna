using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    internal class Rectangulo : FiguraGeometrica
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public override float CalcularArea()
        {
            return Base * Altura;
        }
        public override float CalcularPermietro()
        {
            return 2 * (Base + Altura);
        }
    }
}
