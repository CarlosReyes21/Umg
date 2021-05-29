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
    public class Ventas_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public Ventas_Controller(DbContextSistema context)
        {
            _context = context;
        }

      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ventas_>>> GetVentas_()
        {
            return await _context.Ventass_.ToListAsync();
        }

        [HttpGet("{idVenta_")]

        public async Task<ActionResult<ventas_>> Getventas_(int id)
        {
            var ventas_ = await _context.Ventass_.FindAsync(id);

            if (ventas_ == null)
            {
                return NotFound();
            }

            return ventas_;
        }


      
        [HttpPut("idVenta_")]
        public async Task<IActionResult> putCategoria(int id, ventas_ ventas_)
        {
            if (id != ventas_.idVenta_)
            {
                return BadRequest();
            }

            
            _context.Entry(ventas_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Ventas_Exists(id))
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

        //POst api/Categorias
        [HttpPost]
        public async Task<ActionResult<ventas_>> PostCategoria(ventas_ ventas_)

        {
            _context.Ventass_.Add(ventas_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getventas_", new { id = ventas_.idVenta_ }, ventas_);
        }

        

        [HttpDelete("idVenta_")]
        public async Task<ActionResult<ventas_>> Deleteventas_(int id)
        {
            var ventas_ = await _context.Ventass_.FindAsync(id);

            if (ventas_ == null)
            {
                return NotFound();
            }

            _context.Ventass_.Remove(ventas_);
            await _context.SaveChangesAsync();

            return ventas_;
        }

        private bool Ventas_Exists(int id)
        {
            return _context.Ventass_.Any(e => e.idVenta_ == id);
        }
    }

}