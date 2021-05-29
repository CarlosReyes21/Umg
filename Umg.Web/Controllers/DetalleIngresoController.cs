using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Ventas;

namespace Umg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleIngresoController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public DetalleIngresoController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<detalleIngreso>>> GetCategorias()
        {
            return await _context.DetallesIngresos.ToListAsync();
        }

        // GET api/Categorias/2
        [HttpGet("{idDetalleIngreso")]

        public async Task<ActionResult<detalleIngreso>> GetdetalleIngreso(int id)
        {
            var detalleIngreso = await _context.DetallesIngresos.FindAsync(id);

            if (detalleIngreso == null)
            {
                return NotFound();
            }

            return detalleIngreso;
        }


      
        [HttpPut("idDetalleIngreso")]
        public async Task<IActionResult> putdetalleIngreso(int id, detalleIngreso detalleIngreso)
        {
            if (id != detalleIngreso.idDetalleIngreso)
            {
                return BadRequest();
            }

            _context.Entry(detalleIngreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!DetalleIngresoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

            }

            return NoContent();

        }


        [HttpPost]
        public async Task<ActionResult<detalleIngreso>> PostdetalleIngrso(detalleIngreso detalleIngreso)
        {
            _context.DetallesIngresos.Add(detalleIngreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getdetalleIngreso", new { id = detalleIngreso }, detalleIngreso);
        }

 

        [HttpDelete("idDetalleIngreso")]
        public async Task<ActionResult<detalleIngreso>> DeletedetalleIngrso(int id)
        {
            var detalleIngreso = await _context.DetallesIngresos.FindAsync(id);

            if (detalleIngreso == null)
            {
                return NotFound();
            }

            _context.DetallesIngresos.Remove(detalleIngreso);
            await _context.SaveChangesAsync();

            return detalleIngreso;
        }

        private bool DetalleIngresoExists(int id)
        {
            return _context.DetallesIngresos.Any(e => e.idDetalleIngreso == id);
        }
    }

}