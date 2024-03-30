using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class AreaEnvioIdentificador : IIdentificable<AreaEnvio>
    {
        public bool CompararIdentificador(AreaEnvio entidad, object identificador)
        {
            return entidad.IdAreaEnvio == (int)identificador;
        }

        public void Copiar(AreaEnvio origen, AreaEnvio destino)
        {
            if (destino != null && origen != null)
            {
                destino.Nombre = origen.Nombre;
                destino.IdAreaEnvio = origen.IdAreaEnvio;
                destino.Precio = origen.Precio;
            }
        }

        public IQueryable<AreaEnvio> FiltarPorentidad(IQueryable<AreaEnvio> query, AreaEnvio Entidad)
        {
            return query.Where(x => x.IdAreaEnvio == Entidad.IdAreaEnvio);
        }

        public IQueryable<AreaEnvio> FiltrarPorCodigo(IQueryable<AreaEnvio> query, object Precio)
        {
            return query.Where(x => x.Nombre == (Precio as string));
        }

        public IQueryable<AreaEnvio> FiltrarPorIdentificador(IQueryable<AreaEnvio> query, object identificador)
        {
            return query.Where(x => x.IdAreaEnvio == (int)identificador);
        }
    }
}
