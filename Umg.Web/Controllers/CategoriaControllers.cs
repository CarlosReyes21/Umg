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
    public class CategoriaControllers : ControllerBase
    {

        private readonly DbContextSistema _context;

        public CategoriaControllers(DbContextSistema context)
        {
            _context = context;


        }
   
        [HttpGet]
        public async Task<ActionResult<IEnumerable<categoria>>> GetCategorias()
        {
            return await _context.articulo.ToListAsync();
        }

        [HttpGet("{idcategoria}")]

        public async Task<ActionResult<categoria>> GetCategoria(int id)
        {
            var Categoria = await _context.articulo.FindAsync(id);

            if (Categoria == null)
            {
                return NotFound();
            }

            return Categoria;
        }


       
        [HttpPut("idcategoria")]
        public async Task<IActionResult> putCategoria(int id, categoria categoria)
        {
            if (id != categoria.idCategoria)
            {
                return BadRequest();
            }

            _context.Entry(categoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!CategoriaExists(id))
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
        public async Task<ActionResult<categoria>> PostCategoria(categoria categoria)
        {
            _context.articulo.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getCategoria", new { id = categoria.idCategoria }, categoria);
        }

 

        [HttpDelete("idCategoria")]
        public async Task<ActionResult<categoria>> DeleteCategoria(int id)
        {
            var Categoria = await _context.articulo.FindAsync(id);

            if (Categoria == null)
            {
                return NotFound();
            }

            _context.articulo.Remove(Categoria);
            await _context.SaveChangesAsync();

            return Categoria;
        }

        private bool CategoriaExists(int id)
        {
            return _context.articulo.Any(e => e.idCategoria == id);
        }
    }

}