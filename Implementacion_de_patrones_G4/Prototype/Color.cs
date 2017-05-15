using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.Prototype
{
    class Color : PrototipoColor
    {

        private string color = "";

        public string NombreColor
        {
            get
            {
                return color;
            }
        }

        public Color(String col)
        {
            color = col;
        }

        public override PrototipoColor Clone()
        {
            Console.WriteLine("Clonando clase con Color {0}", NombreColor);
            return this.MemberwiseClone() as PrototipoColor;
        }

    }
}
