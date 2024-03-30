using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Heladeria.API.Data;
using Heladeria.API.Data.Vistas;

namespace Heladeria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloesController : ControllerBase
    {
        private readonly HeladeriaEntidadesContext _context;

        public ArticuloesController(HeladeriaEntidadesContext context)
        {
            _context = context;
        }

        // GET: api/Articuloes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticuloVista>>> GetArticulo(string? nombre = null, string? codigo = null, string? categoria = null)
        {

            if (_context.Articulo == null)
            {
                return NotFound();
            }
            IQueryable<ArticuloVista> consulta = _context.Articulo
                .Include(x => x.IdcategoriaNavigation)
                .Include(x => x.IdProveedorNavigation)
                .Select(x => new ArticuloVista()
                {
                    IdArticulo = x.IdArticulo,
                    Idcategoria = x.Idcategoria,
                    IdProveedor = x.IdProveedor,
                    Codigo = x.Codigo,
                    Cantidad = x.Cantidad,
                    Nombre = x.Nombre,
                    Maximo = x.Maximo,
                    Minimo = x.Minimo,
                    NombreCategoria = x.IdcategoriaNavigation.Nombre,
                    NombreProveedor = x.IdcategoriaNavigation.Nombre,
                    PrecioCompra = x.PrecioCompra,
                    PrecioVenta = x.PrecioVenta,
                    Imagen = x.Imagen
                }); ;
            ;
            if (nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.Contains(nombre));
            }
            if (codigo != null)
            {
                consulta = consulta.Where(x => x.Codigo.Contains(codigo));
            }
            if (categoria != null)
            {
                consulta = consulta.Where(x => x.NombreCategoria.Contains(categoria));
            }
            return await consulta.ToListAsync();//filtrar por los atributos que necesitamos
        }

        // GET: api/Articuloes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Articulo>> GetArticulo(int id)
        {
            if (_context.Articulo == null)
            {
                return NotFound();
            }
            var articulo = await _context.Articulo.FindAsync(id);

            if (articulo == null)
            {
                return NotFound();
            }

            return articulo;
        }

        // PUT: api/Articuloes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticulo(int id, Articulo articulo)
        {
            if (id != articulo.IdArticulo)
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
                if (!ArticuloExists(id))
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

        // POST: api/Articuloes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Articulo>> PostArticulo(Articulo articulo)
        {
            if (_context.Articulo == null)
            {
                return Problem("Entity set 'HeladeriaEntidadesContext.Articulo'  is null.");
            }
            _context.Articulo.Add(articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticulo", new { id = articulo.IdArticulo }, articulo);
        }

        // DELETE: api/Articuloes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticulo(int id)
        {
            if (_context.Articulo == null)
            {
                return NotFound();
            }
            var articulo = await _context.Articulo.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }

            _context.Articulo.Remove(articulo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticuloExists(int id)
        {
            return (_context.Articulo?.Any(e => e.IdArticulo == id)).GetValueOrDefault();
        }
    }
}
