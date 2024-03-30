using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroUsuario: FiltroBase<Usuario>
    {

        public int? IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }

        public override IQueryable<Usuario> AplicarOrdenamiento(IQueryable<Usuario> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(Usuario.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    case nameof(Usuario.Contrasenia):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Contrasenia);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Contrasenia);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdUsuario);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdUsuario);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdUsuario);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdUsuario);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<Usuario> AplicarFiltro(IQueryable<Usuario> consulta)
        {
            if (this.IdUsuario != null)
            {
                consulta = consulta.Where(x => x.IdUsuario == this.IdUsuario);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.StartsWith(this.Nombre));
            }
            if (this.Contrasenia != null)
            {
                consulta = consulta.Where(x => x.Contrasenia.StartsWith(this.Contrasenia));
            }

            return consulta;
        }
    }
}