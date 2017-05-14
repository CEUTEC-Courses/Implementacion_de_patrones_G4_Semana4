using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.Builder
{
    public class MitsubishiLancerBuilder : AutomovilBuilder
    {
        public override void buildColor(string color)
        {
            Automovil.setColorPintura(color);
        }

        public override void buildMarca()
        {
            Automovil.setMarca("Mitsubishi");
        }

        public override void buildModelo()
        {
            Automovil.setModelo("Lancer");
        }

        public override void buildMotor()
        {
            Automovil.setMotor("4B11 2000c Gasolina");
        }

        public override void buildNumeroPuertas(int numeroPuertas)
        {
            Automovil.setNumeroPuertas(numeroPuertas);
        }

        public override void buildTamanoLlantas(int tamanoLlantas)
        {
            Automovil.setTamanoLlantas(tamanoLlantas);
        }

        public override void buildTipo()
        {
            Automovil.setTipo(Tipo_Carro.Turismo);
        }
    }
}
