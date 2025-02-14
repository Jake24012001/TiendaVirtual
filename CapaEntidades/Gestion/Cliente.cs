using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private DateTime fechanaci;
        private string estadocivil;
        private string telefono;

        public Cliente()
        {
        }

        public Cliente(int id, string nombre, DateTime fechanaci, string estadocivil, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechanaci = fechanaci;
            this.estadocivil = estadocivil;
            this.telefono = telefono;
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fechanaci { get => fechanaci; set => fechanaci = value; }
        public string Estadocivil { get => estadocivil; set => estadocivil = value; }
        public string Telefono { get => telefono; set => telefono = value; }

    }
}
