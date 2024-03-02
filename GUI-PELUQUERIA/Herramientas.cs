using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PELUQUERIA
{
    public partial class Herramientas : Form
    {
        Conexion c = new Conexion();
        public Herramientas()
        {
            InitializeComponent();
        }
        //validar el nombre
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                return true;
            }
        }
        //metodo para limpiar los controles 
        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtMarca.Clear();


        }
        //validar precio
        private bool ValidarPrecio()
        {
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                erpError.SetError(txtPrecio, "Debe ingresar un precio");
                return false;
            }
            else
            {

                if (double.TryParse(txtPrecio.Text, out double aux))
                {
                    erpError.SetError(txtPrecio, "");
                    return true;
                }
                else
                {
                    erpError.SetError(txtPrecio, "Debe ingresar un precio valido");
                    return false;
                }

            }
        }
        private bool ValidarMarca()
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                erpError.SetError(txtMarca, "Debe ingresar una marca");
                return false;
            }
            else
            {
                erpError.SetError(txtMarca, "");
                return true;
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false) { return; }
            if (ValidarPrecio() == false) { return; }
            if (ValidarMarca() == false) { return; }
            if (c.validarH(txtNombre.Text) > 0)
            {
                MessageBox.Show("Herramienta ya registrada");
            }
            else
            {

                MessageBox.Show(c.insertarH(txtNombre.Text, Convert.ToDouble(txtPrecio.Text), dtCaducidad.Value.ToString("dd/MM/yyyy"), Convert.ToString(cbEstado.SelectedItem), txtMarca.Text));
                c.llenarT("herramientas", dataGridView1);
            }

            LimpiarControles();
            txtNombre.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c.validarH(txtNombre.Text) > 0)
            {
                c.llenarCH(txtNombre.Text, txtPrecio, dtCaducidad, cbEstado, txtMarca);
                txtNombre.Enabled = false;
                txtMarca.Enabled = false;
                txtPrecio.Enabled = false;
                dtCaducidad.Enabled = false;
                button3.Show();
            }
            else
            {
                MessageBox.Show("No existe esa herramienta");
                LimpiarControles();
                txtNombre.Focus();
                return;
            }

        }

        private void Herramientas_Load(object sender, EventArgs e)
        {
            button3.Hide();
            c.llenarT("herramientas", dataGridView1);
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.actualizarH(txtNombre.Text,cbEstado.Text));
            txtNombre.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtNombre.Enabled = true;
            txtMarca.Enabled = true;
            txtPrecio.Enabled = true;
            dtCaducidad.Enabled = true;
            c.llenarT("herramientas", dataGridView1);
            button3.Hide();
        }
    }
}
