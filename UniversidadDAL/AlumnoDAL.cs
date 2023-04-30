using UniversidadEntidades;

namespace UniversidadDAL
{
    public class AlumnoDAL : IAlumnoDAL
    {
        public Alumno GetAlumno(int id)
        {
            return new Alumno();
        }
    }

    public interface IAlumnoDAL
    { 
    Alumno GetAlumno(int id);
    
    }
}