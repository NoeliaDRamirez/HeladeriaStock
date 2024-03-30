using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroPedido : FiltroBase<Pedido>
    {
        public int? IdPedido { get; set; }
        public int? IdArticulo { get; set; }
        public int? Cantidad { get; set; }
        public int? IdUsuario { get; set; }
        public bool? Leido { get; set; }
        public DateTime Fecha { get; set; }
        public bool? Entregado { get; set; }
        public int? IdTipoPago { get; set; }
        public int? IdAreaEnvio { get; set; }
        public int? IdRepartidor{ get; set; }
        public string Destino { get; set; }
        public decimal? Total { get; set; }

        public override IQueryable<Pedido> AplicarOrdenamiento(IQueryable<Pedido> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(Pedido.IdArticulo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdArticulo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdArticulo);
                        }

                        break;
                    case nameof(Pedido.Leido):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Leido);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Leido);
                        }

                        break;
                    case nameof(Pedido.Cantidad):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Cantidad);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Cantidad);
                        }
                        break;
                    case nameof(Pedido.Total):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Total);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Total);
                        }
                        break;
                    case nameof(Pedido.IdTipoPago):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdTipoPago);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdTipoPago);
                        }
                        break;
                    case nameof(Pedido.IdRepartidor):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdRepartidor);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdRepartidor);
                        }
                        break;
                    case nameof(Pedido.Fecha):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Fecha);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Fecha);
                        }
                        break;
                    case nameof(Pedido.IdUsuario):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdUsuario);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdUsuario);
                        }
                        break;
                    case nameof(Pedido.Entregado):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Entregado);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Entregado);
                        }
                        break;
                    case nameof(Pedido.IdAreaEnvio):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdAreaEnvio);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdAreaEnvio);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdPedido);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdPedido);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdPedido);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdPedido);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<Pedido> AplicarFiltro(IQueryable<Pedido> consulta)
        {
            if (this.IdPedido != null)
            {
                consulta = consulta.Where(x => x.IdPedido == this.IdPedido);
            }
            if (this.Leido != null)
            {
                consulta = consulta.Where(x => x.Leido == this.Leido);
            }
            if (this.IdArticulo != null)
            {
                consulta = consulta.Where(x => x.IdArticulo == this.IdArticulo);
            }
            if (this.Cantidad != null)
            {
                consulta = consulta.Where(x => x.Cantidad == this.Cantidad);
            }
            if (this.Fecha != DateTime.MinValue)
            {
                consulta = consulta.Where(x => x.Fecha == this.Fecha);
            }
            if (this.IdUsuario != null)
            {
                consulta = consulta.Where(x => x.IdUsuario == this.IdUsuario);
            }
            if (this.Entregado != null)
            {
                consulta = consulta.Where(x => x.Entregado == this.Entregado);
            }
            if (this.IdTipoPago != null)
            {
                consulta = consulta.Where(x => x.IdTipoPago == this.IdTipoPago);
            }
            if (this.IdAreaEnvio != null)
            {
                consulta = consulta.Where(x => x.IdAreaEnvio == this.IdAreaEnvio);
            }
            if (this.IdRepartidor != null)
            {
                consulta = consulta.Where(x => x.IdRepartidor == this.IdRepartidor);
            }
            if (this.Destino != null)
            {
                consulta = consulta.Where(x => x.Destino.StartsWith( this.Destino));
            }
            if (this.Total != null)
            {
                consulta = consulta.Where(x => x.Total == this.Total);
            }
            return consulta;
        }

    }
}
