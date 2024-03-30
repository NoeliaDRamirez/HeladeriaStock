using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class UsuarioIdentificador : IIdentificable<Usuario>
    {
        public bool CompararIdentificador(Usuario entidad, object identificador)
        {
            return entidad.IdUsuario == (int)identificador;
        }

        public void Copiar(Usuario origen, Usuario destino)
        {
            if (destino != null && origen != null)
            {
                destino.Nombre = origen.Nombre;
                destino.IdUsuario = origen.IdUsuario;
                destino.Contrasenia= origen.Contrasenia;
            }
        }

        public IQueryable<Usuario> FiltarPorentidad(IQueryable<Usuario> query, Usuario Entidad)
        {
            return query.Where(x => x.IdUsuario == Entidad.IdUsuario);
        }

        public IQueryable<Usuario> FiltrarPorCodigo(IQueryable<Usuario> query, object Contrasenia)
        {
            return query.Where(x => x.Contrasenia == (Contrasenia as string));
        }

        public IQueryable<Usuario> FiltrarPorIdentificador(IQueryable<Usuario> query, object identificador)
        {
            return query.Where(x => x.IdUsuario == (int)identificador);
        }
    }
}
