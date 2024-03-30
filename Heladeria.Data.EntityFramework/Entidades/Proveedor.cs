using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class ProveedorIdentificador : IIdentificable<Proveedor>
    {
        public bool CompararIdentificador(Proveedor entidad, object identificador)
        {
            return entidad.IdProveedor == (int)identificador;
        }

        public void Copiar(Proveedor origen, Proveedor destino)
        {
            if (destino != null && origen != null)
            {
                destino.IdProveedor = origen.IdProveedor;
                destino.Nombre = origen.Nombre;
                destino.Direccion = origen.Direccion;
                destino.Codigo = origen.Codigo;
                destino.Ciudad = origen.Ciudad;
                destino.Pais = origen.Pais;
                destino.Telefono = origen.Telefono;
                destino.IdCondicionFiscal = origen.IdCondicionFiscal;
                destino.CUIT = origen.CUIT;
            }
        }
         public IQueryable<Proveedor> FiltarPorentidad(IQueryable<Proveedor> query, Proveedor Entidad)
        {
            return query.Where(x => x.IdProveedor == Entidad.IdProveedor);
        }

        public IQueryable<Proveedor> FiltrarPorCodigo(IQueryable<Proveedor> query, object Codigo)
        {
            return query.Where(x => x.Codigo == (Codigo as string));
        }

        public IQueryable<Proveedor> FiltrarPorIdentificador(IQueryable<Proveedor> query, object identificador)
        {
            return query.Where(x => x.IdProveedor == (int)identificador);
        }
    }
}