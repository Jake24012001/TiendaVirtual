using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class ProductoLN
    {
        public List<CapaEntidades.Gestion.Producto> VerProducto()
        {
            List<CapaEntidades.Gestion.Producto> lista = new List<CapaEntidades.Gestion.Producto>();
            CapaEntidades.Gestion.Producto oc;
            try
            {
                List<CapaDatos.Productos> auxLista = ProductoCD.listarProducto();
                foreach (CapaDatos.Productos obj in auxLista)
                {
                    oc = new CapaEntidades.Gestion.Producto(obj.idProducto,obj.Codigo,obj.Nombre,obj.Categoria,obj.Precio,obj.Stock,obj.Temporada,obj.Estado);
                    lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostar cliente de la tabla de BD", ex);
            }
            finally
            {

            }
            return lista;
        }
        public bool VerificarCodProducto(int idProdu)
        {
            List<CapaEntidades.Gestion.Producto> categorias = VerProducto();

            return categorias.Any(c => c.Id == idProdu);
        }

        public bool CreateProducto(CapaEntidades.Gestion.Producto oa)
        {
            try
            {
                ProductoCD.InsertarProductos(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar producto en la BD", ex);
            }
        }

        public bool RegistrarVenta(int idProducto, int cantidadVendida, string temporada)
        {
            try
            {
                ProductoCD.RegistrarVenta(idProducto, cantidadVendida, temporada);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al registrar la venta en la BD", ex);
            }
        }

    }
}
