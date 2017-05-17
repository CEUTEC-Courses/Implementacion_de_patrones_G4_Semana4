using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.Interface
{
    /// <summary>
    /// Interface de Clasificar Estudiantes segun promedio
    /// </summary>
    public interface IClasificarEstudiantes
    {
        IEnumerable MostrarListadoAlumnos(List<Alumno> Alumno);

    }
}
