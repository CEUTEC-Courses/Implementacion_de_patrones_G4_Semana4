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
    /// modifica el metodo segun sea promedio Muy Bueno
    /// </summary>
    class ClasificacionEstudiantesMuyBuenos : IClasificarEstudiantes
    {
        public IEnumerable MostrarListadoAlumnos(List<Alumno> Alumnos)
        {
            Console.WriteLine("\nAlumnos con calificacion Muy Buena\n");
            var AlumnosMuyBuenos = from alumno in Alumnos
                                    where alumno.CalcularPromedio() < 90 && alumno.CalcularPromedio()>70
                                   select alumno.Nombre;
            return AlumnosMuyBuenos;
        }
    }
}

