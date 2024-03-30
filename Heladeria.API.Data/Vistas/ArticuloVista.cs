using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.API.Data.Vistas
{
    public class ArticuloVista
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Idcategoria { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public int? Minimo { get; set; }
        public int? Maximo { get; set; }
        public int IdProveedor { get; set; }
        public decimal PrecioVenta { get; set; }
        public string NombreCategoria { get; set; }
        public string NombreProveedor { get; set; }
        public byte[] Imagen { get; set; }
    }
}
