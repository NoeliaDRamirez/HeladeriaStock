using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.API.Data.Vistas
{
    public class PedidoVista
    {
        public int IdPedido { get; set; }
        public int IdUsuario { get; set; }
        public bool? Leido { get; set; }
        public bool? Entregado { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public int IdTipoPago { get; set; }
        public string Destino { get; set; }
        public int? IdAreaEnvio { get; set; }
        public int? IdRepartidor { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Fecha { get; set; }
        public string NombreArticulo { get; set; }
        public string NombreTipoPago { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreAreaEnvio { get; set; }
        public string NombreRepartidor { get; set; }
    }
}
