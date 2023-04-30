﻿namespace UniversidadEntidades
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; } = DateTime.Today;
        public DateTime FechaAlta { get; set; } = DateTime.Today;
    }
}