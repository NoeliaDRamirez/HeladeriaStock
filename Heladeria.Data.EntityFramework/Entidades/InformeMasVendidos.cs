using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class InformeMasVendidosIdentificador : IIdentificable<InformeMasVendidos>
    {
        public bool CompararIdentificador(InformeMasVendidos entidad, object identificador)
        {
            return entidad.Id == (int)identificador;
        }

        public void Copiar(InformeMasVendidos origen, InformeMasVendidos destino)
        {
            if (destino != null && origen != null)
            {
                destino.Nombre = origen.Nombre;
                destino.Id = origen.Id;
                destino.Cantidad= origen.Cantidad;
                destino.Desde = origen.Desde;
                destino.Hasta = origen.Hasta;
            }
        }

        public IQueryable<InformeMasVendidos> FiltarPorentidad(IQueryable<InformeMasVendidos> query, InformeMasVendidos Entidad)
        {
            return query.Where(x => x.Id == Entidad.Id);
        }

        public IQueryable<InformeMasVendidos> FiltrarPorCodigo(IQueryable<InformeMasVendidos> query, object Cantidad)
        {
            return query.Where(x => x.Nombre == (Cantidad as string));
        }

        public IQueryable<InformeMasVendidos> FiltrarPorIdentificador(IQueryable<InformeMasVendidos> query, object identificador)
        {
            return query.Where(x => x.Id == (int)identificador);
        }
    }
}
