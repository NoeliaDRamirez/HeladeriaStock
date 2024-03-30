using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class TipoPagoIdentificador : IIdentificable<TipoPago>
    {
        public bool CompararIdentificador(TipoPago entidad, object identificador)
        {
            return entidad.IdTipoPago == (int)identificador;
        }

        public void Copiar(TipoPago origen, TipoPago destino)
        {
            if (destino != null && origen != null)
            {
                destino.Nombre = origen.Nombre;
                destino.IdTipoPago = origen.IdTipoPago;
                destino.Codigo= origen.Codigo;
            }
        }

        public IQueryable<TipoPago> FiltarPorentidad(IQueryable<TipoPago> query, TipoPago Entidad)
        {
            return query.Where(x => x.IdTipoPago == Entidad.IdTipoPago);
        }

        public IQueryable<TipoPago> FiltrarPorCodigo(IQueryable<TipoPago> query, object Codigo)
        {
            return query.Where(x => x.Nombre == (Codigo as string));
        }

        public IQueryable<TipoPago> FiltrarPorIdentificador(IQueryable<TipoPago> query, object identificador)
        {
            return query.Where(x => x.IdTipoPago == (int)identificador);
        }
    }
}
