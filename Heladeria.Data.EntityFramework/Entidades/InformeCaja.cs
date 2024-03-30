using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data.EntityFramework.Entidades
{
    public partial class InformeCajaIdentificador : IIdentificable<InformeCaja>
    {
        public bool CompararIdentificador(InformeCaja entidad, object identificador)
        {
            return entidad.Id == (int)identificador;
        }

        public void Copiar(InformeCaja origen, InformeCaja destino)
        {
            if (destino != null && origen != null)
            {
                destino.Local = origen.Local;
                destino.Id = origen.Id;
                destino.Aplicacion= origen.Aplicacion;
                destino.Efectivo = origen.Efectivo;
                destino.OtroMedio = origen.OtroMedio;
                destino.Fecha = origen.Fecha;
            }
        }

        public IQueryable<InformeCaja> FiltarPorentidad(IQueryable<InformeCaja> query, InformeCaja Entidad)
        {
            return query.Where(x => x.Id == Entidad.Id);
        }

        public IQueryable<InformeCaja> FiltrarPorCodigo(IQueryable<InformeCaja> query, object Cantidad)
        {
            return query.Where(x => x.Local == int.Parse(Cantidad as string));
        }

        public IQueryable<InformeCaja> FiltrarPorIdentificador(IQueryable<InformeCaja> query, object identificador)
        {
            return query.Where(x => x.Id == (int)identificador);
        }
    }
}
