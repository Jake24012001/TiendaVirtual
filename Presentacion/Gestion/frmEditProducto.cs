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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.Gestion
{
    public partial class frmEditProducto: Form
    {
        ProductoLN olnn = new ProductoLN();
        public frmEditProducto()
        {
            InitializeComponent();
        }

        public Producto CrearObjeto()
        {
            Producto op = new Producto();
            int id = int.Parse(textBox1.Text);
            int cod = int.Parse(textBox2.Text);
            string nombre = textBox3.Text;
            string categoria = textBox4.Text;
            decimal precio = decimal.Parse(textBox5.Text);
            int stock = int.Parse(textBox6.Text);
            string temporada = comboBox2.SelectedItem.ToString();
            string estado=comboBox1.SelectedItem.ToString();
            op = new Producto(id,cod,nombre,categoria,precio,stock,temporada,estado);
            return op;
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
                    // Registrar la venta si se está en el contexto correcto
                    if (label1.Text == "Registrar Venta")
                    {
                        try
                        {
                            int idProducto = int.Parse(textBox1.Text);
                            int cantidadVendida = int.Parse(textBox7.Text); // Suponiendo que textBox2 contiene la cantidad vendida
                            string temporada = comboBox1.SelectedItem.ToString(); // Suponiendo que comboBoxTemporada contiene la temporada

                            ProductoLN productoLN = new ProductoLN();
                            productoLN.RegistrarVenta(idProducto, cantidadVendida, temporada);

                            MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Si no es "Registrar Venta", se procede normalmente
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool validar()
        {

            bool val = true;

            if (textBox1.Text == "" || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || textBox3.Text == "" || textBox4.Text == ""|| textBox2.Text==""|| textBox5.Text==""||textBox6.Text==""
                )
            {
                val = false;
            }

            return val;
        }
    }
}
