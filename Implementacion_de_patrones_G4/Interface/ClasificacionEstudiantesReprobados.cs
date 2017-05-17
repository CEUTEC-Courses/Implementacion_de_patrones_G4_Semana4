using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.Interface
{
    /// <summary>
    /// Clase que iplementa la interface IClasificarEstudiantes y
    /// modifica el metodo segun sea promedio reprobado
    /// </summary>
    class ClasificacionEstudiantesReprobados : IClasificarEstudiantes
    {
        public IEnumerable MostrarListadoAlumnos(List<Alumno> Alumnos)
        {
            Console.WriteLine("\nAlumnos con calificacion Reprobada \n");
            var AlumnosReprobados = from alumno in Alumnos
                                    where alumno.CalcularPromedio() <60
                                    select alumno.Nombre;
            return AlumnosReprobados;
       }
    }
}
