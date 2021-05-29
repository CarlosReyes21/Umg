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
    public class Telefono_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public Telefono_Controller(DbContextSistema context)
        {
            _context = context;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<telefono_>>> GetTelefonos_()
        {
            return await _context.Telefonos_.ToListAsync();
        }

        
        [HttpGet("{idTelefono_")]

        public async Task<ActionResult<telefono_>> Gettelefono_(int id)
        {
            var telefono_ = await _context.Telefonos_.FindAsync(id);

            if (telefono_ == null)
            {
                return NotFound();
            }

            return telefono_;
        }


       
        [HttpPut("idTelefono_")]
        public async Task<IActionResult> puttelefono_(int id, telefono_ telefono_)

        {
            if (id != telefono_.idTelefono)
            {
                return BadRequest();
            }

            
            _context.Entry(telefono_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Telefono_Exists(id))
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
        public async Task<ActionResult<telefono_>> PostCategoria(telefono_ telefono_)
        {
            _context.Telefonos_.Add(telefono_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("gettelefono_", new { id = telefono_.idTelefono }, telefono_);
        }

        

        [HttpDelete("idTelefono_")]
        public async Task<ActionResult<telefono_>> Deletetelefono_(int id)
        {
            var telefono_ = await _context.Telefonos_.FindAsync(id);

            if (telefono_ == null)
            {
                return NotFound();
            }

            _context.Telefonos_.Remove(telefono_);
            await _context.SaveChangesAsync();

            return telefono_;
        }

        private bool Telefono_Exists(int id)
        {
            return _context.Telefonos_.Any(e => e.idTelefono == id);
        }
    }

}
