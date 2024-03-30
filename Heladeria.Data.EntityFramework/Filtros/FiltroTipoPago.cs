using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroTipoPago: FiltroBase<TipoPago>
    {

        public int? IdTipoPago { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public override IQueryable<TipoPago> AplicarOrdenamiento(IQueryable<TipoPago> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(TipoPago.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    case nameof(TipoPago.Codigo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Codigo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Codigo);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdTipoPago);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdTipoPago);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdTipoPago);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdTipoPago);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<TipoPago> AplicarFiltro(IQueryable<TipoPago> consulta)
        {
            if (this.IdTipoPago != null)
            {
                consulta = consulta.Where(x => x.IdTipoPago == this.IdTipoPago);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.StartsWith(this.Nombre));
            }
            if (this.Codigo != null)
            {
                consulta = consulta.Where(x => x.Codigo.StartsWith(this.Codigo));
            }

            return consulta;
        }
    }
}