using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class CompraIdentificador : IIdentificable<Compra>
    {
        public bool CompararIdentificador(Compra entidad, object identificador)
        {
            return entidad.IdCompra == (int)identificador;
        }

        public void Copiar(Compra origen, Compra destino)
        {
            if (destino != null && origen != null)
            {
                destino.IdCompra = origen.IdCompra;
                destino.IdArticulo = origen.IdArticulo;
                destino.Cantidad = origen.Cantidad;
                destino.IdDetalleCompra = origen.IdDetalleCompra;    
                destino.Total = origen.Total;
            }
        }

        public IQueryable<Compra> FiltarPorentidad(IQueryable<Compra> query, Compra Entidad)
        {
            return query.Where(x => x.IdCompra == Entidad.IdCompra);
        }

        public IQueryable<Compra> FiltrarPorCodigo(IQueryable<Compra> query, object Codigo)
        {
            return query;
        }

        public IQueryable<Compra> FiltrarPorIdentificador(IQueryable<Compra> query, object identificador)
        {
            return query.Where(x => x.IdCompra == (int)identificador);
        }
    }
}
