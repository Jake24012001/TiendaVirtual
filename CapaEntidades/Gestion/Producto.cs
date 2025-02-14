using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Producto
    {
        private int id;
        private int codigo;
        private string nombre;
        private string categoria;
        private decimal precio;
        private int stock;
        private string temporada;
        private string estado;

        public Producto()
        {
        }

        public Producto(int id)
        {
            this.id = id;
        }

        public Producto(int id, int codigo, string nombre, string categoria, decimal precio, int stock, string temporada, string estado)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = stock;
            this.temporada = temporada;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Temporada { get => temporada; set => temporada = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
