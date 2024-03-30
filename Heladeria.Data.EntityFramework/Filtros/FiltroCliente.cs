using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Filtros
{
    public class FiltroCliente : FiltroBase<Cliente>
    {
        public int? IdCliente { get; set; }
        public int? IdCondicionFiscal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CUIT { get; set; }


        public override IQueryable<Cliente> AplicarOrdenamiento(IQueryable<Cliente> consulta)
        {
            if (this.Orden != null)
            {
                switch (this.Orden)
                {
                    case nameof(Cliente.IdCondicionFiscal):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.IdCondicionFiscal);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdCondicionFiscal);
                        }

                        break;
                    case nameof(Cliente.Nombre):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Nombre);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Nombre);
                        }
                        break;
                    case nameof(Cliente.Direccion):
                        if (this.Descendente)
                        {
                            consulta = consulta.OrderByDescending(x => x.Direccion);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.Direccion);
                        }
                        break;
                    case nameof(Cliente.CUIT):
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
                            consulta = consulta.OrderByDescending(x => x.IdCliente);
                        }
                        else
                        {
                            consulta = consulta.OrderBy(x => x.IdCliente);
                        }
                        break;
                }
            }
            else
            {
                if (this.Descendente)
                {
                    consulta = consulta.OrderByDescending(x => x.IdCliente);
                }
                else
                {
                    consulta = consulta.OrderBy(x => x.IdCliente);
                }
            }
            if (this.TamanioPagina > 0)
            {
                consulta = consulta.Skip(this.NumeroPagina * this.TamanioPagina).Take(this.TamanioPagina);
            }

            return consulta;
        }

        public override IQueryable<Cliente> AplicarFiltro(IQueryable<Cliente> consulta)
        {
            if (this.IdCliente != null)
            {
                consulta = consulta.Where(x => x.IdCliente == this.IdCliente);
            }
            if (this.IdCondicionFiscal != null)
            {
                consulta = consulta.Where(x => x.IdCondicionFiscal == this.IdCondicionFiscal);
            }
            if (this.Nombre != null)
            {
                consulta = consulta.Where(x => x.Nombre.StartsWith(this.Nombre));
            }
            if (this.Direccion != null)
            {
                consulta = consulta.Where(x => x.Direccion.StartsWith(this.Direccion));
            }
            if (this.CUIT != null)
            {
                consulta = consulta.Where(x => x.CUIT.StartsWith( this.CUIT));
            }
            return consulta;
        }

    }
}
