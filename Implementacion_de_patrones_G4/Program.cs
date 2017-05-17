using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implementacion_de_patrones_G4.Builder;
using Implementacion_de_patrones_G4.Prototype;
using System.Threading;
using Implementacion_de_patrones_G4.Singleton;
using Implementacion_de_patrones_G4.Interface;
using Implementacion_de_patrones_G4.FactoryMethod;

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


            /*Prueba de Interface */
          
            //Se crea una lista de tipo Alumno que se  utilizara en el metodo Mostrar Alumnos
            var ListaAlumnos = new List<Alumno>
            {
              new Alumno {Nombre="Karen", Curso="3BTC", Notas=new List<int> {85,92,75,88}},
              new Alumno {Nombre="Luis",Curso="3BTC",  Notas=new List<int> {92,95,81,98} },
              new Alumno {Nombre="Katherin",Curso="3BTC", Notas=new List<int> {55,50,51,58} },
              new Alumno {Nombre="Merilyn", Curso="3BTC", Notas=new List<int> {100,95,98,100} },
            };

            //se crea una instancia de la Clase Alumno
            Alumno ObjetoAlumno = new Alumno();

            //Comprobamos que se utilizan  las clases que implementan la interface,
            //ya que el Metodo MostrarAlumnos pide comoparametro un objeto de tipo de la interface

            Console.WriteLine("--- Pruebas Interface ---\n");

            var AlumnosExcelentes = new ClasificacionEstudianteExcelentes();
            ObjetoAlumno.MostrarAlumnos(AlumnosExcelentes, ListaAlumnos);

            var AlumnosMuyBuenos = new ClasificacionEstudiantesMuyBuenos();
            ObjetoAlumno.MostrarAlumnos(AlumnosMuyBuenos, ListaAlumnos);

            var AlumnosReprobados = new ClasificacionEstudiantesReprobados();
            ObjetoAlumno.MostrarAlumnos(AlumnosReprobados, ListaAlumnos);
            Console.WriteLine("--- Fin Interface ---\n");

            /*Fin de Prueba Interface */

            /*Prueba de Factory Method */
            Console.WriteLine("--- Prueba Factory Method ---\n");
            //se crea una instancia de la Clase ProspectoDeVentas
            ProspectoDeVentas prospectoVenta = new ProspectoDeVentas();

            prospectoVenta.Nombre = "Evelin Paz";
            prospectoVenta.Telefono = "2556-5471";
            prospectoVenta.Presupuesto = 15000.0;

            // Estado interno de la tienda
            ProspectoMemoria memoria = new ProspectoMemoria();
            memoria.Recuerdo = prospectoVenta.GuardarRecuerdo();

            // Continuar cambiando origen
            prospectoVenta.Nombre = "Jackelyn Pinto";
            prospectoVenta.Telefono = "2510-5210";
            prospectoVenta.Presupuesto = 25000.00;

            // Restaurar estado guardado
            prospectoVenta.RestaurarRecuerdo(memoria.Recuerdo);
            Console.WriteLine("--- Fin Factory Method ---\n");
            /*Fin Prueba de Factory Method */



            Console.ReadLine();
        }
    }
}
