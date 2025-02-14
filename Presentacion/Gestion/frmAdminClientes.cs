using CapaDatos.Gestion;
using CapaLogica.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Gestion
{
    public partial class frmAdminClientes: Form
    {
        public frmAdminClientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = ClienteCD.listarCliente();
        }
    }
}
