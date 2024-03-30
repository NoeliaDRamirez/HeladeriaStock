using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroInformeMasVendidos: FiltroBase<InformeMasVendidos>
    {

        public int? Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }

        public override IQueryable<InformeMasVendidos> AplicarOrdenamiento(IQueryable<InformeMasVendidos> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(InformeMasVendidos.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    case nameof(InformeMasVendidos.Cantidad):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Cantidad);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Cantidad);
                        }
                        break;
                    case nameof(InformeMasVendidos.Desde):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Desde);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Desde);
                        }
                        break;
                    case nameof(InformeMasVendidos.Hasta):
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

        public override IQueryable<InformeMasVendidos> AplicarFiltro(IQueryable<InformeMasVendidos> consulta)
        {
            if (this.Id != null)
            {
                consulta = consulta.Where(x => x.Id == this.Id);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.Contains(this.Nombre));
            }
            if (this.Cantidad != 0)
            {
                consulta = consulta.Where(x => x.Cantidad == this.Cantidad);
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