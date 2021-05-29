using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Almacen;

namespace Umg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class articulo_Controllers : ControllerBase
    {

        private readonly DbContextSistema _context;

        public articulo_Controllers(DbContextSistema context)
        {
            _context = context;


        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<articulo>>> Getarticulo()
        {
            return await _context.Articulos.ToListAsync();
        }

        
        [HttpGet("{idarticulo}")]

        public async Task<ActionResult<articulo>> Getarticulo(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);

            if (articulo == null)
            {
                return NotFound();
            }

            return articulo;
        }


        
        [HttpPut("idarticulo")]
        public async Task<IActionResult> putarticulo(int id, articulo articulo)
        {
            if (id != articulo.idArticulo)
            {
                return BadRequest();
            }

           
            _context.Entry(articulo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!articuloExists(id))
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
        public async Task<ActionResult<articulo>> PostCategoria(articulo articulo)
        {
            _context.Articulos.Add(articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getarticulo", new { id = articulo.idArticulo }, articulo);
        }

      

        [HttpDelete("idCarticulo")]
        public async Task<ActionResult<articulo>> Deletearticulo(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);

            if (articulo == null)
            {
                return NotFound();
            }

            _context.Articulos.Remove(articulo);
            await _context.SaveChangesAsync();

            return articulo;
        }

        private bool articuloExists(int id)
        {
            return _context.Articulos.Any(e => e.idArticulo == id);
        }
    }

}