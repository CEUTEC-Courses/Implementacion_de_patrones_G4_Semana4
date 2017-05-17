using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implementacion_de_patrones_G4.Builder;
using Implementacion_de_patrones_G4.Prototype;
using System.Threading;
using Implementacion_de_patrones_G4.Singleton;

namespace Implementacion_de_patrones_G4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- PATRONES DE CREACION | GRUPO 4 ----\n\n");


            /* Ejemplo Builder */
            Console.WriteLine("--- Pruebas Builder ---\n");

            AutomovilBuilder ToyotaCorolla1 = new ToyotaCorollaBuilder();
            ToyotaCorolla1.buildColor("Negro");
            ToyotaCorolla1.buildNumeroPuertas(5);
            ToyotaCorolla1.buildTamanoLlantas(17);
            ToyotaCorolla1.ImprimirResultado();

            AutomovilBuilder ToyotaHilux1 = new ToyotaHiluxBuilder();
            ToyotaHilux1.buildColor("Rojo");
            ToyotaHilux1.buildNumeroPuertas(4);
            ToyotaHilux1.buildTamanoLlantas(18);
            ToyotaHilux1.ImprimirResultado();

            AutomovilBuilder MitsubishiLancer1 = new MitsubishiLancerBuilder();
            MitsubishiLancer1.buildColor("Azul Electrico");
            MitsubishiLancer1.buildNumeroPuertas(4);
            MitsubishiLancer1.buildTamanoLlantas(16);
            MitsubishiLancer1.ImprimirResultado();

            Console.WriteLine("\n--- Fin de Builder ---\n");

            /* Fin de Builder */

            /* Pruebas Prototype */

            Console.WriteLine("--- Pruebas Prototype ---\n");

            Color rojo = new Color("Rojo");
            Color azul = new Color("Azul");
            Color verde = new Color("Verde");

            Color copiaVerde = verde.Clone() as Color;
            Color copiaAzul = azul.Clone() as Color;
            Color copiaRojo = rojo.Clone() as Color;

            Console.WriteLine("\n--- Fin de Prototype ---\n");

            /* Fin de Prototype  */

            /*Prueba Singleton*/
            Console.WriteLine("--- Pruebas Singleton ---\n");
            
            SingletonPatron s = SingletonPatron.Instance;
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
            s.Nombre, s.HoraArranque.ToLongTimeString()));

            Console.WriteLine(string.Format("Espere mientras se intenta crear una segunda instancia "));
           
            // Hacemos una pausa de cinco segundos
            Thread.Sleep(5000);

            // Intentamos instanciar un segundo Singleton
            SingletonPatron s2 = SingletonPatron.Instance;

            // Comprobamos que ambos objetos son referencias a la misma instancia, que es única
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
            s2.Nombre, s2.HoraArranque.ToLongTimeString()));
            Console.WriteLine(string.Format("Comprobamos por la hora, que la instancia sigue siendo la misma"));
            Console.WriteLine("\n--- Fin de Singleton ---\n");

            /* Fin de Singleton  */

            Console.ReadLine();
        }
    }
}
