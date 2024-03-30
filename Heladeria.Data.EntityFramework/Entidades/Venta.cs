using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class VentaIdentificador : IIdentificable<Venta>
    {
        public bool CompararIdentificador(Venta entidad, object identificador)
        {
            return entidad.IdVenta == (int)identificador;
        }

        public void Copiar(Venta origen, Venta destino)
        {
            if (destino != null && origen != null)
            {
                destino.IdVenta = origen.IdVenta;
                destino.Comentario = origen.Comentario;
                destino.IdCliente = origen.IdCliente;
                destino.Fecha = origen.Fecha;
             //   destino.IdRepartidor = origen.IdRepartidor;
                destino.IdTipoPago = origen.IdTipoPago;
                destino.Total = origen.Total;
                destino.IdDetalle = origen.IdDetalle;
            }
        }

        public IQueryable<Venta> FiltarPorentidad(IQueryable<Venta> query, Venta Entidad)
        {
            return query.Where(x => x.IdVenta == Entidad.IdVenta);
        }

        public IQueryable<Venta> FiltrarPorCodigo(IQueryable<Venta> query, object Codigo)
        {
            return query;
        }

        public IQueryable<Venta> FiltrarPorIdentificador(IQueryable<Venta> query, object identificador)
        {
            return query.Where(x => x.IdVenta == (int)identificador);
        }
    }
}