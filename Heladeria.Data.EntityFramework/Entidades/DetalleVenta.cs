using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class DetalleVentaIdentificador : IIdentificable<DetalleVenta>
    {
        public bool CompararIdentificador(DetalleVenta entidad, object identificador)
        {
            return entidad.IdDetalleVenta == (int)identificador;
        }

        public void Copiar(DetalleVenta origen, DetalleVenta destino)
        {
            if (destino != null && origen != null)
            {
                destino.IdDetalleVenta = origen.IdDetalleVenta;
                destino.IdArticulo = origen.IdArticulo;
                destino.Cantidad = origen.Cantidad;
                destino.PrecioUnitario = origen.PrecioUnitario;
            }
        }

        public IQueryable<DetalleVenta> FiltarPorentidad(IQueryable<DetalleVenta> query, DetalleVenta Entidad)
        {
            return query.Where(x => x.IdDetalleVenta == Entidad.IdDetalleVenta);
        }

        public IQueryable<DetalleVenta> FiltrarPorCodigo(IQueryable<DetalleVenta> query, object Codigo)
        {
            return query;
        }

        public IQueryable<DetalleVenta> FiltrarPorIdentificador(IQueryable<DetalleVenta> query, object identificador)
        {
            return query.Where(x => x.IdDetalleVenta == (int)identificador);
        }
    }
}