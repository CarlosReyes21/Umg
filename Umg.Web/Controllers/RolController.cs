using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Usuarios;

namespace Umg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public RolController(DbContextSistema context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<rol>>> GetRols()
        {
            return await _context.Rols.ToListAsync();
        }

      
        [HttpGet("{idRol}")]

        public async Task<ActionResult<rol>> GetRol(int id)
        {
            var rol = await _context.Rols.FindAsync(id);

            if (rol == null)
            {
                return NotFound();
            }

            return rol;
        }


        
        [HttpPut("idRol")]
        public async Task<IActionResult> putrol(int id, rol rol
            )
        {
            if (id != rol.idRol)
            {
                return BadRequest();
            }

          
            _context.Entry(rol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!RolExists(id))
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
        public async Task<ActionResult<rol>> PostCategoria(rol rol)
        {
            _context.Rols.Add(rol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getrol", new { id = rol.idRol }, rol);
        }

      

        [HttpDelete("idRol")]
        public async Task<ActionResult<rol>> Deleterol(int id)
        {
            var rol = await _context.Rols.FindAsync(id);

            if (rol == null)
            {
                return NotFound();
            }

            _context.Rols.Remove(rol);
            await _context.SaveChangesAsync();

            return rol;
        }

        private bool RolExists(int id)
        {
            return _context.Rols.Any(e => e.idRol == id);
        }
    }

}