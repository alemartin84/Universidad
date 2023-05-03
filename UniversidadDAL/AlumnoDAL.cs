using Dapper;
using Microsoft.Data.Sqlite;
using UniversidadEntidades;


namespace UniversidadDAL
{
    public class AlumnoDAL : IAlumnoDAL
    {
        public Alumno GetAlumno(int id)
        {
            using (var connection = new SqliteConnection(@"Data Source=f:\DBcarrera.db"))
            {
                //connection.Open();

                var sql =
                @"SELECT *
                    FROM alumno";

                var alumno = connection.QueryFirst<Alumno>(sql);

                return alumno;
            }
        }
    }

    public interface IAlumnoDAL
    { 
    Alumno GetAlumno(int id);
    
    }
}