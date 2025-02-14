using CapaEntidades.Gestion;
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
    public partial class frmAdminProductos: Form
    {
        ProductoLN producto = new ProductoLN();
        public frmAdminProductos()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            dataGridView1.DataSource = producto.VerProducto();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            frmEditProducto frm = new frmEditProducto();
            frm.label1.Text = "Insertar Producto";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                CapaEntidades.Gestion.Producto op = frm.CrearObjeto();
                producto.CreateProducto(op);
                frm.Hide();
                Listar();
            }
        }

        
    }
}
