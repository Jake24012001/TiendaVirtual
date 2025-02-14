using CapaDatos;
using CapaDatos.Gestion;
using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class CarritoLN
    {
        public List<CapaEntidades.Gestion.Carrito> VerCarrito()
        {
            List<CapaEntidades.Gestion.Carrito> lista = new List<CapaEntidades.Gestion.Carrito>();
            CapaEntidades.Gestion.Carrito oc;
            try
            {
                List<CapaDatos.Carrito> auxLista = CarritoCD.listarCarrito();
                foreach (CapaDatos.Carrito obj in auxLista)
                {
                    oc = new CapaEntidades.Gestion.Carrito(obj.idCarrito,obj.idCliente,obj.idProducto,obj.Descuento,obj.StockFinal,obj.Preciofinal);
                    lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostar carrito de la tabla de BD", ex);
            }
            finally
            {

            }
            return lista;
        }

        public bool CreateCategoria(CapaEntidades.Gestion.Carrito oa)
        {
            try
            {
                CarritoCD.InsertarCarrito(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar carrito en la BD", ex);
            }
        }

        public bool UpdateCategoria(CapaEntidades.Gestion.Carrito oa)
        {
            try
            {
                CarritoCD.ModificarCarrito(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al actualizar carrito en la BD");
            }
        }
        public bool DeleteCategoria(CapaEntidades.Gestion.Carrito oa)
        {

            try
            {
                CarritoCD.EliminarCarrito(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar carrito en la BD");
            }
        }
    }
}
