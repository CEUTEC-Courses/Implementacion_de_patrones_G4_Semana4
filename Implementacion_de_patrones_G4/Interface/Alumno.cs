using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementacion_de_patrones_G4.Interface
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Curso { get; set; }
        public List<int> Notas { get; set; }

        public double CalcularPromedio()
        {
            var SumarNotas = from notas in Notas
                             select notas;
            var NotaPromedio = SumarNotas.Average(x => x);
            return NotaPromedio;

        }

        public void MostrarAlumnos(IClasificarEstudiantes Clasificar, List<Alumno> Alumnos)
        {
            foreach (var item in Clasificar.MostrarListadoAlumnos(Alumnos))
            {
                Console.WriteLine(item);
            }
        }
    }
}