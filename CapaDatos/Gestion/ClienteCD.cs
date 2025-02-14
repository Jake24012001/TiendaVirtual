using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class ClienteCD
    {
         public static List<Cliente> listarCliente()
        {
            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    return DB.Cliente.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosEx("Error al listar la tabla clientes", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
