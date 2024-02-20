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
                erpError.SetError(txtPrecio, "");
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
            else { MessageBox.Show("Herramienta Registrada"); }
            LimpiarControles();
            txtNombre.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            else
            {
                MessageBox.Show("No existe esa herramienta");
                LimpiarControles();
                txtNombre.Focus();
                return;
            }

        }
    }
}
