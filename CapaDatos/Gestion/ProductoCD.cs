using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades.Gestion;
namespace CapaDatos.Gestion
{
    public class ProductoCD
    {
        public static List<Productos> listarProducto()
        {
            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    return DB.Productos.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosEx("Error al listar la tabla productos", ex);
            }
            finally
            {
                DB = null;
            }
        }

        public static void InsertarProductos(Producto oc)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CPInsertarProducto(oc.Id, oc.Codigo, oc.Nombre, oc.Categoria, oc.Precio, oc.Stock, oc.Temporada, oc.Estado);
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

        public static void RegistrarVenta(int idProducto, int cantidadVendida, string temporada)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    DB.CPRegistrarVentaProducto(idProducto, cantidadVendida, temporada);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosEx("Error al registrar la venta", ex);
            }
            finally
            {
                DB = null;
            }
        }

    }
}
