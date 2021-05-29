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
    public class Ingreso_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public Ingreso_Controller(DbContextSistema context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ingreso_>>> GetCategorias()
        {
            return await _context.Ingresos_.ToListAsync();
        }

        
        [HttpGet("{idIngreso_")]

        public async Task<ActionResult<ingreso_>> Getingreso_(int id)
        {
            var ingreso_ = await _context.Ingresos_.FindAsync(id);

            if (ingreso_ == null)
            {
                return NotFound();
            }

            return ingreso_;
        }


         
        [HttpPut("idIngreso_")]
        public async Task<IActionResult> putingreso_(int id, ingreso_ ingreso_)
        {
            if (id != ingreso_.idIngreso_)
            {
                return BadRequest();
            }

            
            _context.Entry(ingreso_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Ingreso_Exists(id))
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
        public async Task<ActionResult<ingreso_>> Postingreso_(ingreso_ ingreso_)
        {
            _context.Ingresos_.Add(ingreso_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getingreso_", new { id = ingreso_.idIngreso_ }, ingreso_);
        }

        

        [HttpDelete("idIngreso_")]
        public async Task<ActionResult<ingreso_>> Deleteiingreso_(int id)
        {
            var ingreso_ = await _context.Ingresos_.FindAsync(id);

            if (ingreso_ == null)
            {
                return NotFound();
            }

            _context.Ingresos_.Remove(ingreso_);
            await _context.SaveChangesAsync();

            return ingreso_;
        }

        private bool Ingreso_Exists(int id)
        {
            return _context.Ingresos_.Any(e => e.idIngreso_ == id);
        }
    }

}