using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class PedidoIdentificador : IIdentificable<Pedido>
    {
        public bool CompararIdentificador(Pedido entidad, object identificador)
        {
            return entidad.IdPedido == (int)identificador;
        }

        public void Copiar(Pedido origen, Pedido destino)
        {
            if (destino != null && origen != null)
            {
                destino.IdPedido = origen.IdPedido;
                destino.IdArticulo = origen.IdArticulo;
                destino.Cantidad = origen.Cantidad;
                destino.Destino = origen.Destino;    
                destino.IdAreaEnvio = origen.IdAreaEnvio;
                destino.Leido = origen.Leido;
                destino.Entregado = origen.Entregado;
                destino.IdUsuario = origen.IdUsuario;
                destino.IdTipoPago = origen.IdTipoPago;
                destino.IdRepartidor = origen.IdRepartidor;
                destino.Total = origen.Total;
                destino.Fecha = origen.Fecha;
            }
        }

        public IQueryable<Pedido> FiltarPorentidad(IQueryable<Pedido> query, Pedido Entidad)
        {
            return query.Where(x => x.IdPedido == Entidad.IdPedido);
        }

        public IQueryable<Pedido> FiltrarPorCodigo(IQueryable<Pedido> query, object Codigo)
        {
            return query;
        }

        public IQueryable<Pedido> FiltrarPorIdentificador(IQueryable<Pedido> query, object identificador)
        {
            return query.Where(x => x.IdPedido == (int)identificador);
        }
    }
}
