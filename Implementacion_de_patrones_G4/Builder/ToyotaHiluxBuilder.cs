using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.Builder
{
    public class ToyotaHiluxBuilder : AutomovilBuilder
    {
        public override void buildColor(string color)
        {
            Automovil.setColorPintura(color);
        }

        public override void buildMarca()
        {
            Automovil.setMarca("Toyota");
        }

        public override void buildModelo()
        {
            Automovil.setModelo("Hilux");
        }

        public override void buildMotor()
        {
            Automovil.setMotor("1KD-FTV 3000cc Diesel");
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
            Automovil.setTipo(Tipo_Carro.Pickup);
        }
    }
}
