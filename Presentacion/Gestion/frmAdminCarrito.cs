using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Gestion;
using CapaDatos;
using CapaEntidades.Gestion;
namespace Presentacion.Gestion
{
    
    public partial class frmAdminCarrito: Form
    {
        CarritoLN producto = new CarritoLN();
        ProductoLN productoLN= new ProductoLN();
        public frmAdminCarrito()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            dataGridView1.DataSource = producto.VerCarrito();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            frmEditCarrito frm = new frmEditCarrito();
            frm.label1.Text = "Insertar Carrito";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                CapaEntidades.Gestion.Carrito op = frm.CrearObjeto();
                producto.CreateCarrito(op);
                frm.Hide();
                ListarCarritos();
            }
        }
        public void Modificar()
        {
            try
            {
                CapaEntidades.Gestion.Carrito op = dataGridView1.CurrentRow.DataBoundItem as CapaEntidades.Gestion.Carrito;
                frmEditCarrito frm = new frmEditCarrito();
                frm.label1.Text = "Modificar Producto";
                frm.auxiliar = op;
                frm.setDatos();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    producto.UpdateCarrito(frm.CrearObjeto());
                    frm.Hide();
                    ListarCarritos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una fila a modificar");
            }
        }

        private void ListarCarritos()
        {
            dataGridView1.DataSource = producto.VerCarrito();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("Desea eliminar producto carrito", "Eliminar Carrito", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        CapaEntidades.Gestion.Carrito obp = dataGridView1.CurrentRow.DataBoundItem as CapaEntidades.Gestion.Carrito;
                        CapaEntidades.Gestion.Carrito op = new CapaEntidades.Gestion.Carrito(obp.IdProducto);
                        producto.DeleteCarrito(op);
                        ListarCarritos();
                    }

                }
                else
                    MessageBox.Show("Seleccione la fila");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" error al eliminar datos" + ex.Message);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmAdminProductos frm = new frmAdminProductos();
            frm.ShowDialog();   
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
