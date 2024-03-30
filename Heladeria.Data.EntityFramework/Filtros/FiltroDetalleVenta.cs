using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroDetalleVenta : FiltroBase<DetalleVenta>
    {
        public int? IdDetalleVenta { get; set; }
        public int? IdArticulo { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }


        public override IQueryable<DetalleVenta> AplicarOrdenamiento(IQueryable<DetalleVenta> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(DetalleVenta.IdArticulo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdArticulo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Articulo);
                        }

                        break;
                    case nameof(DetalleVenta.Cantidad):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Cantidad);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Cantidad);
                        }
                        break;
                    case nameof(DetalleVenta.PrecioUnitario):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.PrecioUnitario);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.PrecioUnitario);
                        }
                        break;

                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdDetalleVenta);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdDetalleVenta);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdDetalleVenta);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdDetalleVenta);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<DetalleVenta> AplicarFiltro(IQueryable<DetalleVenta> consulta)
        {
            if (this.IdDetalleVenta != null)
            {
                consulta = consulta.Where(x => x.IdDetalleVenta == this.IdDetalleVenta);
            }
            if (this.IdArticulo != null)
            {
                consulta = consulta.Where(x => x.IdArticulo == this.IdArticulo);
            }
            if (this.Cantidad != null)
            {
                consulta = consulta.Where(x => x.Cantidad == this.Cantidad);
            }
            if (this.PrecioUnitario != null)
            {
                consulta = consulta.Where(x => x.PrecioUnitario == this.PrecioUnitario);
            }
            return consulta;
        }

    }
}
