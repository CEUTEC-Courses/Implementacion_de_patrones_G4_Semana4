using System;

namespace Implementacion_de_patrones_G4.FactoryMethod
{
    /// <summary>
    /// Clase Origen
    /// </summary>
   public class ProspectoDeVentas
    {
        private string _nombre;
        private string _telefono;
        private double _presupuesto;

        // Get y Set de Nombre
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                Console.WriteLine("Nombre:  " + _nombre);
            }
        }

        // Get y Set de telefono
        public string Telefono
        {
            get { return _telefono; }
            set
            {
                _telefono = value;
                Console.WriteLine("Telefono: " + _telefono);
            }
        }

        // Get y Set de presupuesto
        public double Presupuesto
        {
            get { return _presupuesto; }
            set
            {
                _presupuesto = value;
                Console.WriteLine("Presupuesto: " + _presupuesto);
            }
        }

        // Tienda de Recuerdo
        public Recuerdo GuardarRecuerdo()
        {
            Console.WriteLine("\nGuardando Estado --\n");
            return new Recuerdo(_nombre, _telefono, _presupuesto);
        }
        // Restaurar Recuerdo
        public void RestaurarRecuerdo(Recuerdo recuerdo)
        {
            Console.WriteLine("\nRestaurando recuerdo --\n");
            this.Nombre = recuerdo.Nombre;
            this.Telefono = recuerdo.Telefono;
            this.Presupuesto = recuerdo.Presupuesto;
        }
    }

}