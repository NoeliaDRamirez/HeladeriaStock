using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroAreaEnvio: FiltroBase<AreaEnvio>
    {

        public int? IdAreaEnvio { get; set; }
        public string Nombre { get; set; }
        public decimal? Precio { get; set; }

        public override IQueryable<AreaEnvio> AplicarOrdenamiento(IQueryable<AreaEnvio> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(AreaEnvio.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    case nameof(AreaEnvio.Precio):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Precio);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Precio);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdAreaEnvio);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdAreaEnvio);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdAreaEnvio);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdAreaEnvio);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<AreaEnvio> AplicarFiltro(IQueryable<AreaEnvio> consulta)
        {
            if (this.IdAreaEnvio != null)
            {
                consulta = consulta.Where(x => x.IdAreaEnvio == this.IdAreaEnvio);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.StartsWith(this.Nombre));
            }
            if (this.Precio != null)
            {
                consulta = consulta.Where(x => x.Precio == this.Precio);
            }

            return consulta;
        }
    }
}