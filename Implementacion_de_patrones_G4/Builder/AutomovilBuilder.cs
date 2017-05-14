using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.Builder
{
    public abstract class AutomovilBuilder
    {

        protected Automovil auto;

        public Automovil Automovil
        {
            get { return auto; }
        }

        public void ImprimirResultado()
        {
            auto.ImprimirResultado();
        }
        public AutomovilBuilder()
        {
            auto = new Automovil();
            buildMarca();
            buildModelo();
            buildMotor();
            buildTipo();
        }

        public abstract void buildMarca();
        public abstract void buildModelo();
        public abstract void buildMotor();
        public abstract void buildTipo();
        public abstract void buildTamanoLlantas(int tamanoLlantas);
        public abstract void buildColor(String color);
        public abstract void buildNumeroPuertas(int numeroPuertas);

    }
}
