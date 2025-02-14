using Presentacion.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Seguridad
{
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void administrarCarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminCarrito"] == null)
            {
                frmAdminCarrito fc = new frmAdminCarrito
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }

        private void administrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminCliente"] == null)
            {
                frmAdminClientes fc = new frmAdminClientes
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminProducto"] == null)
            {
                frmAdminProductos fc = new frmAdminProductos
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }
    }
}
