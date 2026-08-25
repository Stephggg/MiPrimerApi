// Autor: Stephany Flores

using Microsoft.AspNetCore.Mvc;

namespace MiPrimerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PresentacionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var presentacion = new
            {
                saludo = "Olaaa",

                datosPersonales = new
                {
                    nombreCompleto = "Stephany Flores",
                    edad = 21,
                    fechaNacimiento = new DateTime(2005, 8, 2),
                    colorFavorito = "Rosa"
                },

                datosAcademicos = new
                {
                    cif = "23020108",
                    anioUniversitario = 4,
                    carrera = "Ingeniería en Sistemas",
                    esEstudiante = true
                }
            };

            return Ok(presentacion);
        }
    }
}