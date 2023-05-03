namespace UniversidadEntidades
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateTime Fecha_Nacimiento { get; set; } = DateTime.Today;
        public DateTime Fecha_Alta { get; set; } = DateTime.Today;
    }
}