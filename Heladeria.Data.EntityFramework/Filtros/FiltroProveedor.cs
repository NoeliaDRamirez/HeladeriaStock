using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroProveedor : FiltroBase<Proveedor>
    {
        public int? IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Codigo { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public int? IdCondicionFiscal { get; set; }
        public string CUIT { get; set; }

        public override IQueryable<Proveedor> AplicarOrdenamiento(IQueryable<Proveedor> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(Proveedor.Codigo):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Codigo);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Codigo);
                        }

                        break;
                    case nameof(Proveedor.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    case nameof(Proveedor.Ciudad):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Ciudad);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Ciudad);
                        }
                        break;
                    case nameof(Proveedor.Direccion):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Direccion);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Direccion);
                        }
                        break;
                    case nameof(Proveedor.Pais):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Pais);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Pais);
                        }
                        break;
                    case nameof(Proveedor.Telefono):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Telefono);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Telefono);
                        }
                        break;
                    case nameof(Proveedor.IdCondicionFiscal):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdCondicionFiscal);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdCondicionFiscal);
                        }
                        break;
                    case nameof(Proveedor.CUIT):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.CUIT);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.CUIT);
                        }
                        break;
                    default:
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdProveedor);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdProveedor);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdProveedor);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdProveedor);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<Proveedor> AplicarFiltro(IQueryable<Proveedor> consulta)
        {
            if (this.IdProveedor != null)
            {
                consulta = consulta.Where(x => x.IdProveedor == this.IdProveedor);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.StartsWith(this.Nombre));
            }
            if (this.Codigo != null)
            {
                consulta = consulta.Where(x => x.Codigo.StartsWith(this.Codigo));
            }
            if (this.Direccion != null)
            {
                consulta = consulta.Where(x => x.Direccion.StartsWith(this.Direccion));
            }
            if (this.Ciudad != null)
            {
                consulta = consulta.Where(x => x.Ciudad.StartsWith(this.Ciudad));
            }
            if (this.Pais != null)
            {
                consulta = consulta.Where(x => x.Pais.StartsWith(this.Pais));
            }
            if (this.Telefono != null)
            {
                consulta = consulta.Where(x => x.Telefono.StartsWith(this.Telefono));
            }
            if (this.CUIT != null)
            {
                consulta = consulta.Where(x => x.CUIT.StartsWith(this.CUIT));
            }
            if (this.IdCondicionFiscal != null)
            {
                consulta = consulta.Where(x => x.IdCondicionFiscal == this.IdCondicionFiscal);
            }

            return consulta;
        }
    }
}
