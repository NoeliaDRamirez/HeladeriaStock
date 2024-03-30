using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroRepartidor: FiltroBase<Repartidor>
    {
        public int? IdRepartidor { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }

        public override IQueryable<Repartidor> AplicarOrdenamiento(IQueryable<Repartidor> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(Repartidor.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    case nameof(Repartidor.Celular):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Celular);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Celular);
                        }
                        break;
                    case nameof(Repartidor.DNI):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.DNI);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.DNI);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdRepartidor);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdRepartidor);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdRepartidor);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdRepartidor);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<Repartidor> AplicarFiltro(IQueryable<Repartidor> consulta)
        {
            if (this.IdRepartidor != null)
            {
                consulta = consulta.Where(x => x.IdRepartidor == this.IdRepartidor);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.StartsWith(this.Nombre));
            }
            if (this.Celular != null)
            {
                consulta = consulta.Where(x => x.Celular.StartsWith(this.Celular));
            }
            if (this.DNI != null)
            {
                consulta = consulta.Where(x => x.DNI.StartsWith(this.DNI));
            }

            return consulta;
        }
    }
}