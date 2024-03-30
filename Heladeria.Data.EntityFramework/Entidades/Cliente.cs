using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class ClienteIdentificador : IIdentificable<Cliente>
    {
        public bool CompararIdentificador(Cliente entidad, object identificador)
        {
            return entidad.IdCliente == (int)identificador;
        }

        public void Copiar(Cliente origen, Cliente destino)
        {
            if (destino != null && origen != null)
            {
                destino.IdCliente = origen.IdCliente;
                destino.IdCondicionFiscal = origen.IdCondicionFiscal;
                destino.Nombre = origen.Nombre;
                destino.Direccion = origen.Direccion;
                destino.CUIT = origen.CUIT;            
            }
        }

        public IQueryable<Cliente> FiltarPorentidad(IQueryable<Cliente> query, Cliente Entidad)
        {
            return query.Where(x => x.IdCliente == Entidad.IdCliente);
        }

        public IQueryable<Cliente> FiltrarPorCodigo(IQueryable<Cliente> query, object Codigo)
        {
            return query;
        }

        public IQueryable<Cliente> FiltrarPorIdentificador(IQueryable<Cliente> query, object identificador)
        {
            return query.Where(x => x.IdCliente == (int)identificador);
        }
    }
}
