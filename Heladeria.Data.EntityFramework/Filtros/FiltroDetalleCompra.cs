using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroDetalleCompra : FiltroBase<DetalleCompra>
    {
        public int? IdDetalleCompra { get; set; }
        public int? Lote { get; set; }
        public int? IdProveedor { get; set; }
        public DateTime Fecha { get; set; }


        public override IQueryable<DetalleCompra> AplicarOrdenamiento(IQueryable<DetalleCompra> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(DetalleCompra.IdProveedor):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdProveedor);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdProveedor);
                        }

                        break;
                    case nameof(DetalleCompra.Fecha):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Fecha);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Fecha);
                        }
                        break;
                    case nameof(DetalleCompra.Lote):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Lote);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Lote);
                        }
                        break;

                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdDetalleCompra);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdDetalleCompra);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdDetalleCompra);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdDetalleCompra);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<DetalleCompra> AplicarFiltro(IQueryable<DetalleCompra> consulta)
        {
            if (this.IdDetalleCompra != null)
            {
                consulta = consulta.Where(x => x.IdDetalleCompra == this.IdDetalleCompra);
            }
            if (this.IdProveedor != null)
            {
                consulta = consulta.Where(x => x.IdProveedor == this.IdProveedor);
            }
            if (this.Lote != null)
            {
                consulta = consulta.Where(x => x.Lote == this.Lote);
            }
            if (this.Fecha != DateTime.MinValue)
            {
                consulta = consulta.Where(x => x.Fecha == this.Fecha);
            }
            return consulta;
        }

    }
}
