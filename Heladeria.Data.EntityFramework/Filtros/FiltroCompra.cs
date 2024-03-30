using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroCompra : FiltroBase<Compra>
    {
        public int? IdCompra { get; set; }
        public int? IdArticulo { get; set; }
        public int? Cantidad { get; set; }
        public int? IdDetalleCompra { get; set; }
        public decimal? Total { get; set; }


        public override IQueryable<Compra> AplicarOrdenamiento(IQueryable<Compra> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(Compra.IdArticulo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdArticulo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdArticulo);
                        }

                        break;
                    case nameof(Compra.Total):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Total);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Total);
                        }

                        break;
                    case nameof(Compra.Cantidad):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Cantidad);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Cantidad);
                        }
                        break;
                    case nameof(Compra.IdDetalleCompra):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdDetalleCompra);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdDetalleCompra);
                        }
                        break;                   
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdCompra);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdCompra);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdCompra);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdCompra);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<Compra> AplicarFiltro(IQueryable<Compra> consulta)
        {
            if (this.IdCompra != null)
            {
                consulta = consulta.Where(x => x.IdCompra == this.IdCompra);
            }
            if (this.Total != null)
            {
                consulta = consulta.Where(x => x.Total == this.Total);
            }
            if (this.IdArticulo != null)
            {
                consulta = consulta.Where(x => x.IdArticulo == this.IdArticulo);
            }
            if (this.Cantidad != null)
            {
                consulta = consulta.Where(x => x.Cantidad == this.Cantidad);
            }
            if (this.IdDetalleCompra != null)
            {
                consulta = consulta.Where(x => x.IdDetalleCompra == this.IdDetalleCompra);
            }
            return consulta;
        }

    }
}
