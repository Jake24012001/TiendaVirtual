using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Carrito
    {
        private int id;
        private int idCliente;
        private int idProducto;
        private decimal descuento;
        private int stockfinal;
        private decimal preciototal;
        public Carrito()
        {
        }

        public Carrito(int id)
        {
            this.id = id;
        }
        public Carrito(int id, int idCliente, int idProducto, decimal descuento, int stockfinal, decimal preciototal)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.idProducto = idProducto;
            this.descuento = descuento;
            this.stockfinal = stockfinal;
            this.preciototal = preciototal;
        }

        public int Id { get => id; set => id = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public decimal Descuento { get => descuento; set => descuento = value; }
        public int Stockfinal { get => stockfinal; set => stockfinal = value; }
        public decimal Preciototal { get => preciototal; set => preciototal = value; }
    }
}
