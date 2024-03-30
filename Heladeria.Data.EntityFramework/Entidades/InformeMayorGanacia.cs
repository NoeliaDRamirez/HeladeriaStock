using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class InformeMayorGananciaIdentificador : IIdentificable<InformeMayorGanancia>
    {
        public bool CompararIdentificador(InformeMayorGanancia entidad, object identificador)
        {
            return entidad.Id == (int)identificador;
        }

        public void Copiar(InformeMayorGanancia origen, InformeMayorGanancia destino)
        {
            if (destino != null && origen != null)
            {
                destino.Nombre = origen.Nombre;
                destino.Id = origen.Id;
                destino.Monto = origen.Monto;
                destino.Desde = origen.Desde;
                destino.Hasta = origen.Hasta;
                destino.Cantidad = origen.Cantidad;
            }
        }

        public IQueryable<InformeMayorGanancia> FiltarPorentidad(IQueryable<InformeMayorGanancia> query, InformeMayorGanancia Entidad)
        {
            return query.Where(x => x.Id == Entidad.Id);
        }

        public IQueryable<InformeMayorGanancia> FiltrarPorCodigo(IQueryable<InformeMayorGanancia> query, object Cantidad)
        {
            return query.Where(x => x.Nombre == (Cantidad as string));
        }

        public IQueryable<InformeMayorGanancia> FiltrarPorIdentificador(IQueryable<InformeMayorGanancia> query, object identificador)
        {
            return query.Where(x => x.Id == (int)identificador);
        }
    }
}
