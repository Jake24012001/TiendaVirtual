using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class CarritoCD
    {
        public static List<Carrito> listarCarrito()
        {
            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    return DB.Carrito.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosEx("Error al listar la tabla carrito", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarProductos(CapaEntidades.Gestion.Carrito oc)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CPInsertarCarrito(oc.Id,oc.IdCliente,oc.IdProducto,oc.Descuento,oc.Stockfinal,oc.Preciototal);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosEx("Error al insertar tabla productos", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void ModificarProducto(CapaEntidades.Gestion.Carrito oc)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CPModificarCarrito(oc.Id, oc.IdCliente, oc.IdProducto, oc.Descuento, oc.Stockfinal, oc.Preciototal);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosEx("Error al modificar tabla carrito", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void EliminarProductos(CapaEntidades.Gestion.Carrito oc)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CPEliminarCarrito(oc.Id);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosEx("Error al eliminar tabla carrito", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
