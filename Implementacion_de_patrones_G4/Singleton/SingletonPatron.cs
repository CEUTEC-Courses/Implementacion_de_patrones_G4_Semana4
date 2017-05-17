using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.Singleton
{
   class SingletonPatron
    {
        // Declaramos un atributo del mismo tipo de la clase con carácter estático
        public static SingletonPatron _instancia = null;

        public string Nombre { get; set; }
        public DateTime HoraArranque { get; set; }

        // Constructor privado. Únicamente puede ser invocado desde el interior
        // de la propia clase
        public SingletonPatron()
        {
            Nombre = "Patrón Singleton";
            HoraArranque = DateTime.Now;
        }

        // Property de solo lectura
        public static SingletonPatron Instance
        {
            get
            {
                // Si el singleton no ha sido creado previamente, se instancia.
                // En caso contrario, se devolvera el que haya sido creado previamente
                if (_instancia == null)
                    _instancia = new SingletonPatron();

                // Se devuelve la instancia
                return _instancia;
            }
        }
    }
}
