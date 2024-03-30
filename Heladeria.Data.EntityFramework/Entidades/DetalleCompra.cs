using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class DetalleCompraIdentificador : IIdentificable<DetalleCompra>
    {
        public bool CompararIdentificador(DetalleCompra entidad, object identificador)
        {
            return entidad.IdDetalleCompra == (int)identificador;
        }

        public void Copiar(DetalleCompra origen, DetalleCompra destino)
        {
            if (destino != null && origen != null)
            {
                destino.IdDetalleCompra = origen.IdDetalleCompra;
                destino.IdProveedor = origen.IdProveedor;
                destino.Lote = origen.Lote;
                destino.Fecha = origen.Fecha;
            }
        }

        public IQueryable<DetalleCompra> FiltarPorentidad(IQueryable<DetalleCompra> query, DetalleCompra Entidad)
        {
            return query.Where(x => x.IdDetalleCompra == Entidad.IdDetalleCompra);
        }

        public IQueryable<DetalleCompra> FiltrarPorCodigo(IQueryable<DetalleCompra> query, object Codigo)
        {
            return query;
        }

        public IQueryable<DetalleCompra> FiltrarPorIdentificador(IQueryable<DetalleCompra> query, object identificador)
        {
            return query.Where(x => x.IdDetalleCompra == (int)identificador);
        }
    }
}
