using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadDAL;

namespace UniversidadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly IAlumnoDAL _AlumnoDAL;
        public AlumnoController(IAlumnoDAL alumnoDAL)
        {
            _AlumnoDAL = alumnoDAL;
        }

        [HttpGet]
        public IActionResult GetAlumno()
        {

            return Ok(_AlumnoDAL.GetAlumno(1));
        }
    }
}
