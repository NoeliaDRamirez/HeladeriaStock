using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroVenta : FiltroBase<Venta>
    {
        public int? IdVenta { get; set; }
        public string Comentario { get; set; }
        public int? IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        //public int? IdRepartidor { get; set; }
        public int? IdTipoPago { get; set; }
        public decimal? Total { get; set; }
        public int? IdDetalle { get; set; }

        public override IQueryable<Venta> AplicarOrdenamiento(IQueryable<Venta> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(Venta.Comentario):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Comentario);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Comentario);
                        }

                        break;
                    case nameof(Venta.IdCliente):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdCliente);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdCliente);
                        }
                        break;
                    case nameof(Venta.Fecha):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Fecha);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Fecha);
                        }
                        break;
                   /* case nameof(Venta.IdRepartidor):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdRepartidor);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdRepartidor);
                        }
                        break;*/
                    case nameof(Venta.IdTipoPago):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdTipoPago);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdTipoPago);
                        }
                        break;
                    case nameof(Venta.Total):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Total);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Total);
                        }
                        break;
                    case nameof(Venta.IdDetalle):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdDetalle);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdDetalle);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdVenta);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdVenta);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdVenta);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdVenta);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<Venta> AplicarFiltro(IQueryable<Venta> consulta)
        {
            if (this.IdVenta != null)
            {
                consulta = consulta.Where(x => x.IdVenta == this.IdVenta);
            }
            if (this.Comentario != null)
            {
                consulta = consulta.Where(x => x.Comentario == this.Comentario);
            }
            if (this.IdCliente != null)
            {
                consulta = consulta.Where(x => x.IdCliente == this.IdCliente);
            }
            if (this.Fecha != DateTime.MinValue)
            {
                consulta = consulta.Where(x => x.Fecha == this.Fecha);
            }
           /* if (this.IdRepartidor != null)
            {
                consulta = consulta.Where(x => x.IdRepartidor == this.IdRepartidor);
            }*/
            if (this.IdTipoPago != null)
            {
                consulta = consulta.Where(x => x.IdTipoPago == this.IdTipoPago);
            }
            if (this.Total != null)
            {
                consulta = consulta.Where(x => x.Total == this.Total);
            }
            if (this.IdDetalle != null)
            {
                consulta = consulta.Where(x => x.IdDetalle == this.IdDetalle);
            }


            return consulta;
        }

    }
}