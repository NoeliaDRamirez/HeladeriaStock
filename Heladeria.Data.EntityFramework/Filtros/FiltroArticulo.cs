using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroArticulo : FiltroBase<Articulo>
    {
        public int? IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IDCategoria { get; set; }
        public int? PrecioCompra { get; set; }
        public int? Cantidad { get; set; }
        public int? Minimo { get; set; }
        public int? Maximo { get; set; }
        public int? IdProveedor { get; set; }
        public int? PrecioVenta { get; set; }
        public byte[] imagen { get; set; }

        public override IQueryable<Articulo> AplicarOrdenamiento(IQueryable<Articulo> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(Articulo.IDCategoria):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IDCategoria);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IDCategoria);
                        }

                        break;
                    case nameof(Articulo.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    case nameof(Articulo.Codigo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Codigo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Codigo);
                        }
                        break;
                    case nameof(Articulo.PrecioCompra):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.PrecioCompra);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.PrecioCompra);
                        }
                        break;
                    case nameof(Articulo.Cantidad):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Cantidad);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Cantidad);
                        }
                        break;
                    case nameof(Articulo.Minimo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Minimo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Minimo);
                        }
                        break;
                    case nameof(Articulo.Maximo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Maximo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Maximo);
                        }
                        break;
                    case nameof(Articulo.IdProveedor):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdProveedor);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdProveedor);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdArticulo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdArticulo);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdArticulo);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdArticulo);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<Articulo> AplicarFiltro(IQueryable<Articulo> consulta)
        {
            if (this.IdArticulo != null)
            {
                consulta = consulta.Where(x => x.IdArticulo == this.IdArticulo);
            }
            if (this.IDCategoria != null)
            {
                consulta = consulta.Where(x => x.IDCategoria == this.IDCategoria);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.StartsWith(this.Nombre));
            }
            if (this.Codigo != null)
            {
                consulta = consulta.Where(x => x.Codigo == this.Codigo);
            }
            if (this.PrecioCompra != null)
            {
                consulta = consulta.Where(x => x.PrecioCompra == this.PrecioCompra);
            }
            if (this.Cantidad != null)
            {
                consulta = consulta.Where(x => x.Cantidad == this.Cantidad);
            }
            if (this.Minimo != null)
            {
                consulta = consulta.Where(x => x.Minimo == this.Minimo);
            }
            if (this.Maximo != null)
            {
                consulta = consulta.Where(x => x.Maximo == this.Maximo);
            }
            if (this.PrecioVenta != null)
            {
                consulta = consulta.Where(x => x.PrecioVenta == this.PrecioVenta);
            }
            if (this.IdProveedor != null)
            {
                consulta = consulta.Where(x => x.IdProveedor == this.IdProveedor);
            }
            return consulta;
        }

    }
}
