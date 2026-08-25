// Autor: Stephany Flores

using Microsoft.AspNetCore.Mvc;

namespace MiPrimerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalificacionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Clasificar(string nombre, double nota)
        {
            // Validar que la nota esté entre 0 y 100
            if (nota < 0 || nota > 100)
            {
                return BadRequest(new
                {
                    mensaje = "La nota debe estar entre 0 y 100."
                });
            }

            string nivel;
            string descriptor;

            if (nota < 60)
            {
                nivel = "Logro deficiente";
                descriptor = "Dominio nulo: no se evidencian las habilidades, destrezas y capacidades esperadas.";
            }
            else if (nota < 70)
            {
                nivel = "Logro en proceso inicial";
                descriptor = "Dominio limitado: se evidencian habilidades parciales y dificultad para aplicarlas de forma autónoma.";
            }
            else if (nota < 80)
            {
                nivel = "Logro en proceso intermedio";
                descriptor = "Dominio parcial: aplica conocimientos esenciales, aunque requiere consolidar su integración y transferencia.";
            }
            else if (nota < 90)
            {
                nivel = "Logrado suficientemente";
                descriptor = "Dominio suficiente: aplica de manera integrada las habilidades y conocimientos en situaciones propias de la asignatura.";
            }
            else
            {
                nivel = "Logro destacado";
                descriptor = "Dominio sobresaliente: evidencia autonomía, calidad técnica, innovación y transferencia del aprendizaje.";
            }

            var resultado = new
            {
                estudiante = nombre,
                nota = nota,
                nivelDesempeno = nivel,
                descriptor = descriptor
            };

            return Ok(resultado);
        }
    }
}