using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class CategoriaIdentificador : IIdentificable<Categoria>
    {
        public bool CompararIdentificador(Categoria entidad, object identificador)
        {
            return entidad.IdCategoria == (int)identificador;
        }

        public void Copiar(Categoria origen, Categoria destino)
        {
            if (destino != null && origen != null)
            {
                destino.Nombre = origen.Nombre;
                destino.IdCategoria = origen.IdCategoria;
            }
        }

        public IQueryable<Categoria> FiltarPorentidad(IQueryable<Categoria> query, Categoria Entidad)
        {
            return query.Where(x => x.IdCategoria == Entidad.IdCategoria);
        }

        public IQueryable<Categoria> FiltrarPorCodigo(IQueryable<Categoria> query, object Codigo)
        {
            return query.Where(x => x.Nombre == (Codigo as string));
        }

        public IQueryable<Categoria> FiltrarPorIdentificador(IQueryable<Categoria> query, object identificador)
        {
            return query.Where(x => x.IdCategoria == (int)identificador);
        }
    }
}
