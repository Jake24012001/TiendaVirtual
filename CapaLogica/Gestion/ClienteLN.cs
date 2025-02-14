using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class ClienteLN
    {
        public List<CapaEntidades.Gestion.Cliente> VerCliente()
        {
            List<CapaEntidades.Gestion.Cliente> lista = new List<CapaEntidades.Gestion.Cliente>();
            CapaEntidades.Gestion.Cliente oc;
            try
            {
                List<CapaDatos.Cliente> auxLista = ClienteCD.listarCliente();
                foreach (CapaDatos.Cliente obj in auxLista)
                {
                    oc = new CapaEntidades.Gestion.Cliente(obj.idCliente,obj.Nombre,obj.FechaNacimiento,obj.EstadoCivil,obj.Telefono);
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
    }
}
