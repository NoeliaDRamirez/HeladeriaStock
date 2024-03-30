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
    public class PedidosController : ControllerBase
    {
        private readonly HeladeriaEntidadesContext _context;

        public PedidosController(HeladeriaEntidadesContext context)
        {
            _context = context;
        }

        // GET: api/Pedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PedidoVista>>> GetPedido(string? area = null , string? articulo = null , string? usuario = null)
        {
            if (_context.Pedido == null)
            {
                return NotFound();
            }
            IQueryable<PedidoVista> consulta = _context.Pedido
                .Include(x => x.IdArticuloNavigation)
                .Include(x => x.IdRepartidorNavigation)
                .Include(x => x.IdTipoPagoNavigation)
                .Include(x => x.IdUsuarioNavigation)
                .Include(x => x.IdAreaEnvioNavigation)
                .Select(x => new PedidoVista()
                {
                    IdArticulo = x.IdArticulo,
                    IdRepartidor = x.IdRepartidor,
                    IdAreaEnvio = x.IdAreaEnvio,
                    IdTipoPago = x.IdTipoPago,
                    IdUsuario = x.IdUsuario,
                    IdPedido = x.IdPedido,
                    Cantidad = x.Cantidad,
                    Total = x.Total,
                    Leido = x.Leido,
                    Entregado = x.Entregado,
                    Destino = x.Destino,
                    Fecha = x.Fecha,
                    NombreRepartidor = x.IdRepartidorNavigation.Nombre,
                    NombreAreaEnvio = x.IdAreaEnvioNavigation.Nombre,
                    NombreUsuario = x.IdUsuarioNavigation.Nombre,
                    NombreTipoPago = x.IdTipoPagoNavigation.Nombre,
                    NombreArticulo= x.IdArticuloNavigation.Nombre,
                }); ;
            ;
            if (area != null)
            {
                consulta = consulta.Where(x => x.NombreAreaEnvio.Contains(area));
            }
            if (articulo != null)
            {
                consulta = consulta.Where(x => x.NombreArticulo.Contains(articulo));
            }
            if (usuario != null)
            {
                consulta = consulta.Where(x => x.NombreUsuario.Contains(usuario));
            }
            return await consulta.ToListAsync();//filtrar por los atributos que necesitamos
        }

        // GET: api/Pedidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var pedido = await _context.Pedido.FindAsync(id);

            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }

        // PUT: api/Pedidos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, Pedido pedido)
        {
            if (id != pedido.IdPedido)
            {
                return BadRequest();
            }

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoExists(id))
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

        // POST: api/Pedidos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
        {
            _context.Pedido.Add(pedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedido", new { id = pedido.IdPedido }, pedido);
        }

        // DELETE: api/Pedidos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedido(int id)
        {
            var pedido = await _context.Pedido.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }

            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedido.Any(e => e.IdPedido == id);
        }
    }
}
