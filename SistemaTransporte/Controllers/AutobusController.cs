using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaTransporte.Models;

namespace SistemaTransporte.Controllers
{
    [Route("api/autobus")]
    [ApiController]
    public class AutobusController : ControllerBase
    {
        private readonly TransporteEscolarContext _context;

        public AutobusController(TransporteEscolarContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("crear")]
        public async Task<IActionResult> CrearAutobus(Autobus autobus)
        {
            //guardar el autobus en la base de datos
            await _context.Autobus.AddAsync(autobus);
            await _context.SaveChangesAsync();

            //devolver un mensaje de exito
            return Ok();
        }

        [HttpGet]
        [Route("lista")]
        public async Task<ActionResult<IEnumerable<Autobus>>> ObtenerAutobuses()
        {
            //Obten la lista de autobuses de la base de datos
            var autobus = await _context.Autobus.ToListAsync();

            //devuelve una lista de productos
            return Ok(autobus);
        }

        [HttpGet]
        [Route("buscar")]
        public async Task<IActionResult> BuscarAutobus(int id)
        {
            //obtener el autobus de la base de datos
            Autobus autobus = await _context.Autobus.FindAsync(id);

            //devolver el objeto
            if (autobus == null)
            {
                return NotFound();
            }

            return Ok(autobus);
        }

        [HttpPut]
        [Route("editar")]
        public async Task<IActionResult> EditarAutobus(int id, Autobus autobus)
        {
            //Actualizar el autobus en la base de datos
            var autobusExistente = await _context.Autobus.FindAsync(id);
            autobusExistente!.Modelo = autobus.Modelo;
            autobusExistente.Marca = autobus.Marca;
            autobusExistente.Capacidad = autobus.Capacidad;

            await _context.SaveChangesAsync();

            //devolver un mensaje de exito
            return Ok();
        }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<IActionResult> EliminarAutobus(int id)
        {
            //Eliminar autobus de la base de datos
            var autobusBorrado = await _context.Autobus.FindAsync(id);
            _context.Autobus.Remove(autobusBorrado!);

            await _context.SaveChangesAsync();

            //Devolver un mensaje de exito
            return Ok();
        }
    }
}
