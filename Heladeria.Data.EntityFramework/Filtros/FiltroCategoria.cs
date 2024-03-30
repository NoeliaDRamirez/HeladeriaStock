using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroCategoria: FiltroBase<Categoria>
    {
        public int? IdCategoria { get; set; }
        public string Nombre { get; set; }

        public override IQueryable<Categoria> AplicarOrdenamiento(IQueryable<Categoria> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(Categoria.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdCategoria);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdCategoria);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdCategoria);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdCategoria);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<Categoria> AplicarFiltro(IQueryable<Categoria> consulta)
        {
            if (this.IdCategoria != null)
            {
                consulta = consulta.Where(x => x.IdCategoria == this.IdCategoria);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.StartsWith(this.Nombre));
            }

            return consulta;
        }
    }
}
