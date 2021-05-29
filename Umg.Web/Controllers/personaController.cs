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
    public class PersonaController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public PersonaController(DbContextSistema context)
        {
            _context = context;
        }

      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<persona>>> GetPersonas()
        {
            return await _context.Personas.ToListAsync();
        }

       
        [HttpGet("{idPersona}")]

        public async Task<ActionResult<persona>> GetPersona(int id)
        {
            var Persona = await _context.Personas.FindAsync(id);

            if (Persona == null)
            {
                return NotFound();
            }

            return Persona;
            ;
        }


     
        [HttpPut("idPersona")]
        public async Task<IActionResult> putpersona(int id, persona persona)
        {
            if (id != persona.idPersona)
            {
                return BadRequest();
            }

            
            _context.Entry(persona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!PersonaExists(id))
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
        public async Task<ActionResult<persona>> PostCategoria(persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getpersona", new { id = persona.idPersona }, persona);
        }

        

        [HttpDelete("idPersona")]
        public async Task<ActionResult<persona>> Deletepersona(int id)
        {
            var persona = await _context.Personas.FindAsync(id);

            if (persona == null)
            {
                return NotFound();
            }

            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();

            return persona;
        }

        private bool PersonaExists(int id)
        {
            return _context.Personas.Any(e => e.idPersona == id);
        }
    }

}