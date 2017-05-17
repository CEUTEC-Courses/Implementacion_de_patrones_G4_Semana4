using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Implementacion_de_patrones_G4.Interface
{
    /// <summary>
    /// Clase que iplementa la interface IClasificarEstudiantes y
    /// modifica el metodo segun sea promedio Excelente
    /// </summary>
    class ClasificacionEstudianteExcelentes :IClasificarEstudiantes
    {
        public IEnumerable MostrarListadoAlumnos(List<Alumno> Alumnos)
        {
            Console.WriteLine("\nAlumnos con calificacion Excelente \n");
            var AlumnosExcelentes = from alumno in Alumnos
                                    where alumno.CalcularPromedio() > 90
                                    select alumno.Nombre;
            return AlumnosExcelentes;
        }
    }
}
