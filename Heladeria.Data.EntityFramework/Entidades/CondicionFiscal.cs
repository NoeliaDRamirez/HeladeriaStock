using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework
{
    public partial class CondicionFiscalIdentificador : IIdentificable<CondicionFiscal>
    {
        public bool CompararIdentificador(CondicionFiscal entidad, object identificador)
        {
            return entidad.IdCondicionFiscal == (int)identificador;
        }

        public void Copiar(CondicionFiscal origen, CondicionFiscal destino)
        {
            if (destino != null && origen  != null)
            {
                destino.Tipo = origen.Tipo;               
                destino.IdCondicionFiscal = origen.IdCondicionFiscal;
            }
        }

        public IQueryable<CondicionFiscal> FiltarPorentidad(IQueryable<CondicionFiscal> query, CondicionFiscal Entidad)
        {
            return query.Where(x=> x.IdCondicionFiscal == Entidad.IdCondicionFiscal);
        }

        public IQueryable<CondicionFiscal> FiltrarPorCodigo(IQueryable<CondicionFiscal> query, object Codigo)
        {
            return query.Where(x => x.Tipo == (Codigo as string));
        }

        public IQueryable<CondicionFiscal> FiltrarPorIdentificador(IQueryable<CondicionFiscal> query, object identificador)
        {
            return query.Where(x => x.IdCondicionFiscal == (int)identificador);
        }
    }
}
