using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroCondicionFiscal : FiltroBase<CondicionFiscal>
    {
        public int? IdCondicionFiscal { get; set; }
        public string Tipo { get; set; }

        public override IQueryable<CondicionFiscal> AplicarOrdenamiento(IQueryable<CondicionFiscal> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(CondicionFiscal.Tipo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Tipo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Tipo);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdCondicionFiscal);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdCondicionFiscal);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdCondicionFiscal);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdCondicionFiscal);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<CondicionFiscal> AplicarFiltro(IQueryable<CondicionFiscal> consulta)
        {
            if (this.IdCondicionFiscal != null)
            {
                consulta = consulta.Where(x => x.IdCondicionFiscal == this.IdCondicionFiscal);
            }
            if (this.Tipo != null)
            {
                consulta = consulta.Where(x => x.Tipo.StartsWith(this.Tipo));
            }

            return consulta;
        }

    }
}
