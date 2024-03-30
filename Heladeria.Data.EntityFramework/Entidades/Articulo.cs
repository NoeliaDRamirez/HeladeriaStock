using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class ArticuloIdentificador : IIdentificable<Articulo>
    {
        public bool CompararIdentificador(Articulo entidad, object identificador)
        {
            return entidad.IdArticulo == (int)identificador;
        }

        public void Copiar(Articulo origen, Articulo destino)
        {
            if (destino != null && origen != null)
            {
                destino.IdArticulo = origen.IdArticulo;
                destino.IDCategoria = origen.IDCategoria;
                destino.Nombre = origen.Nombre;
                destino.Codigo = origen.Codigo;
                destino.Cantidad = origen.Cantidad;
                destino.PrecioVenta = origen.PrecioVenta;
                destino.PrecioCompra = origen.PrecioCompra;
                destino.Maximo = origen.Maximo;
                destino.Minimo = origen.Minimo;
                destino.IdProveedor = origen.IdProveedor;
                destino.Imagen = origen.Imagen;

            }
        }

        public IQueryable<Articulo> FiltarPorentidad(IQueryable<Articulo> query, Articulo Entidad)
        {
            return query.Where(x => x.IdArticulo == Entidad.IdArticulo);
        }

        public IQueryable<Articulo> FiltrarPorCodigo(IQueryable<Articulo> query, object Codigo)
        {
            return query;
        }

        public IQueryable<Articulo> FiltrarPorIdentificador(IQueryable<Articulo> query, object identificador)
        {
            return query.Where(x => x.IdArticulo == (int)identificador);
        }
    }
}
