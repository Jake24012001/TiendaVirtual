using CapaEntidades.Gestion;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Presentacion.Gestion
{
    public partial class frmEditCarrito: Form
    {
        ClienteLN oln = new ClienteLN();
        ProductoLN olnn = new ProductoLN();
        public Carrito auxiliar;
        public frmEditCarrito()
        {
            InitializeComponent();
            CargarDatosCliente();
            CargarDatosProducto();
        }


        public void CargarDatosCliente()
        {
            var cliente = oln.VerCliente();
            if (cliente != null && cliente.Count > 0)
            {
                comboBox1.DataSource = cliente;
                comboBox1.DisplayMember = "Nombre";
                comboBox1.ValueMember = "id";

            }
        }
        public void CargarDatosProducto()
        {
            var producto = olnn.VerProducto();
            if (producto != null && producto.Count > 0)
            {
                comboBox2.DataSource = producto;
                comboBox2.DisplayMember = "Nombre";
                comboBox2.ValueMember = "id";
            }
        }
        public Carrito CrearObjeto()
        {
            Carrito op = new Carrito();
            int id=int.Parse(textBox1.Text);
            int idCliente = int.Parse(comboBox1.SelectedValue.ToString());
            int idProducto = int.Parse(comboBox2.SelectedValue.ToString());
            decimal descuento = decimal.Parse(textBox2.Text);
            int stockfinal = int.Parse(textBox3.Text);
            decimal preciototal = decimal.Parse(textBox4.Text);
            op= new Carrito(id, idCliente, idProducto, descuento, stockfinal, preciototal);
            return op;
        }

        public void setDatos()
        {
            try
            {
                textBox1.ReadOnly=true;
                textBox1.Text=auxiliar.Id.ToString();
                textBox2.Text = auxiliar.Descuento.ToString();
                textBox3.Text = auxiliar.Stockfinal.ToString();
                textBox4.Text = auxiliar.Preciototal.ToString();
                comboBox1.SelectedItem = auxiliar.IdCliente;
                comboBox2.SelectedItem = auxiliar.IdProducto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool claveRepetida = false;

            if (validar())
            {
                if (label1.Text == "Insertar Producto")
                {
                    if (olnn.VerificarCodProducto(int.Parse(textBox1.Text)))
                    {
                        MessageBox.Show("El código del producto ya existe. Por favor, ingrese un código diferente.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        claveRepetida = true;
                    }
                }
                if (!claveRepetida)
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool validar()
        {
            bool val = true;

            if (textBox1.Text == "" || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || textBox3.Text == "" || textBox4.Text == ""
                )
            {
                val = false;
            }

            return val;
        }
    }
}
