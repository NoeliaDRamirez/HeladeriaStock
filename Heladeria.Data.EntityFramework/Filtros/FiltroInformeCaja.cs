using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroInformeCaja: FiltroBase<InformeCaja>
    {

        public int? Id { get; set; }
        public int? Local { get; set; }
        public int? Aplicacion { get; set; }
        public decimal? Efectivo { get; set; }
        public decimal? OtroMedio { get; set; }
        public DateTime Fecha { get; set; }

        public override IQueryable<InformeCaja> AplicarOrdenamiento(IQueryable<InformeCaja> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(InformeCaja.Local):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Local);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Local);
                        }
                        break;
                    case nameof(InformeCaja.Efectivo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Efectivo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Efectivo);
                        }
                        break;
                    case nameof(InformeCaja.OtroMedio):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.OtroMedio);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.OtroMedio);
                        }
                        break;
                    case nameof(InformeCaja.Aplicacion):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Aplicacion);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Aplicacion);
                        }
                        break;
                    case nameof(InformeCaja.Fecha):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Fecha);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Fecha);
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
                    consulta = consulta.OrderByDescending(x => x.Id);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.Id);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<InformeCaja> AplicarFiltro(IQueryable<InformeCaja> consulta)
        {
            if (this.Id != null)
            {
                consulta = consulta.Where(x => x.Id == this.Id);
            }
            if (this.Local != null)
            {
                consulta = consulta.Where(x => x.Local == this.Local);
            }
            if (this.Aplicacion != null)
            {
                consulta = consulta.Where(x => x.Aplicacion == this.Aplicacion);
            }
            if (this.Efectivo != null)
            {
                consulta = consulta.Where(x => x.Efectivo == this.Efectivo);
            }
            if (this.OtroMedio != null)
            {
                consulta = consulta.Where(x => x.OtroMedio == this.OtroMedio);
            }
            if (this.Fecha != DateTime.MinValue)
            {
                consulta = consulta.Where(x => x.Fecha == this.Fecha);
            }

            return consulta;
        }
    }
}