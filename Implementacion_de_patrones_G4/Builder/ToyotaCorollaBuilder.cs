using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.Builder
{
    public class ToyotaCorollaBuilder : AutomovilBuilder
    {
        public override void buildColor(String color)
        {
            Automovil.setColorPintura(color);
        }

        public override void buildMarca()
        {
            Automovil.setMarca("Toyota");
        }

        public override void buildModelo()
        {
            Automovil.setModelo("Corolla");
        }

        public override void buildMotor()
        {
            Automovil.setMotor("2ZR-FAE 1800cc");
        }

        public override void buildNumeroPuertas(int numero)
        {
            Automovil.setNumeroPuertas(numero);
        }

        public override void buildTamanoLlantas(int tamanio)
        {
            Automovil.setTamanoLlantas(tamanio);
        }

        public override void buildTipo()
        {
            Automovil.setTipo(Tipo_Carro.Turismo);
        }
    }
}
