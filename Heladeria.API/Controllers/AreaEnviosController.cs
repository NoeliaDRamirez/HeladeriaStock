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
    public class AreaEnviosController : ControllerBase
    {
        private readonly HeladeriaEntidadesContext _context;

        public AreaEnviosController(HeladeriaEntidadesContext context)
        {
            _context = context;
        }

        // GET: api/AreaEnvios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AreaEnvioVista>>> GetAreaEnvio(string? nombre = null, int? id = null)
        {
            if (_context.AreaEnvio == null)
            {
                return NotFound();
            }
            IQueryable<AreaEnvioVista> consulta = _context.AreaEnvio
                .Select(x => new AreaEnvioVista()
                {
                    IdAreaEnvio = x.IdAreaEnvio,
                    Precio = x.Precio,
                    Nombre = x.Nombre
                }); ;
            ;
            if (nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.Contains(nombre));
            }
            if (id != null)
            {
                consulta = consulta.Where(x => x.IdAreaEnvio == id);
            }
            return await consulta.ToListAsync();//filtrar por los atributos que necesitamos
        }

        // GET: api/AreaEnvios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AreaEnvio>> GetAreaEnvio(int id)
        {
            var areaEnvio = await _context.AreaEnvio.FindAsync(id);

            if (areaEnvio == null)
            {
                return NotFound();
            }

            return areaEnvio;
        }

        // PUT: api/AreaEnvios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAreaEnvio(int id, AreaEnvio areaEnvio)
        {
            if (id != areaEnvio.IdAreaEnvio)
            {
                return BadRequest();
            }

            _context.Entry(areaEnvio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AreaEnvioExists(id))
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

        // POST: api/AreaEnvios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AreaEnvio>> PostAreaEnvio(AreaEnvio areaEnvio)
        {
            _context.AreaEnvio.Add(areaEnvio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAreaEnvio", new { id = areaEnvio.IdAreaEnvio }, areaEnvio);
        }

        // DELETE: api/AreaEnvios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAreaEnvio(int id)
        {
            var areaEnvio = await _context.AreaEnvio.FindAsync(id);
            if (areaEnvio == null)
            {
                return NotFound();
            }

            _context.AreaEnvio.Remove(areaEnvio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AreaEnvioExists(int id)
        {
            return _context.AreaEnvio.Any(e => e.IdAreaEnvio == id);
        }
    }
}
