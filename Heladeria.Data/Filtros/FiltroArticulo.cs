using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Data
{
    public class FiltroArticulo: FiltroBase
    {
        public int? IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IdCategoria { get; set; }
        public int? PrecioCompra { get; set; }
        public int? Cantidad { get; set; }
        public int? Minimo { get; set; }
        public int? Maximo { get; set; }
        public int? IdProveedor { get; set; }
        public int? PrecioVenta { get; set; }
    }
}
