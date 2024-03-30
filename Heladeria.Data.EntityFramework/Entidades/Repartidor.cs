using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class RepartidorIdentificador : IIdentificable<Repartidor>
    {
        public bool CompararIdentificador(Repartidor entidad, object identificador)
        {
            return entidad.IdRepartidor == (int)identificador;
        }

        public void Copiar(Repartidor origen, Repartidor destino)
        {
            if (destino != null && origen != null)
            {
                destino.Nombre = origen.Nombre;
                destino.IdRepartidor = origen.IdRepartidor;
                destino.Celular = origen.Celular;
                destino.DNI= origen.DNI;
            }
        }

        public IQueryable<Repartidor> FiltarPorentidad(IQueryable<Repartidor> query, Repartidor Entidad)
        {
            return query.Where(x => x.IdRepartidor == Entidad.IdRepartidor);
        }

        public IQueryable<Repartidor> FiltrarPorCodigo(IQueryable<Repartidor> query, object Codigo)
        {
            return query.Where(x => x.Nombre == (Codigo as string));
        }

        public IQueryable<Repartidor> FiltrarPorIdentificador(IQueryable<Repartidor> query, object identificador)
        {
            return query.Where(x => x.IdRepartidor == (int)identificador);
        }
    }
}
