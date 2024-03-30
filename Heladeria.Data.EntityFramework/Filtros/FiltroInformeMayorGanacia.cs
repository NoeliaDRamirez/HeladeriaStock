using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroInformeMayorGanacia: FiltroBase<InformeMayorGanancia>
    {
        public string Nombre { get; set; }
        public decimal? Monto { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public int? Cantidad { get; set; }
        public int? Id { get; set; }

        public override IQueryable<InformeMayorGanancia> AplicarOrdenamiento(IQueryable<InformeMayorGanancia> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(InformeMayorGanancia.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    case nameof(InformeMayorGanancia.Monto):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Monto);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Monto);
                        }
                        break;
                    case nameof(InformeMayorGanancia.Desde):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Desde);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Desde);
                        }
                        break;
                    case nameof(InformeMayorGanancia.Cantidad):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Cantidad);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Cantidad);
                        }
                        break;
                    case nameof(InformeMayorGanancia.Hasta):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Hasta);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Hasta);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Id);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Id);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.Desde);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.Desde);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<InformeMayorGanancia> AplicarFiltro(IQueryable<InformeMayorGanancia> consulta)
        {
            if (this.Id != null)
            {
                consulta = consulta.Where(x => x.Id == this.Id);
            }
            if (this.Cantidad != null)
            {
                consulta = consulta.Where(x => x.Cantidad == this.Cantidad);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.Contains(this.Nombre));
            }
            if (this.Monto != null)
            {
                consulta = consulta.Where(x => x.Monto == this.Monto);
            }
            if (this.Desde != DateTime.MinValue)
            {
                consulta = consulta.Where(x => x.Desde == this.Desde);
            }
            if (this.Hasta != DateTime.MinValue)
            {
                consulta = consulta.Where(x => x.Hasta == this.Hasta);
            }


            return consulta;
        }
    }
}