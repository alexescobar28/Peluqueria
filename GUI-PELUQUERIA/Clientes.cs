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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false) { return; }
            if (ValidarCedula() == false) { return; }
            if (ValidarApellido() == false) { return; }
            if (ValidarDireccion() == false) { return; }
            if (ValidarCorreo() == false) { return; }
            if (ValidarTelefono() == false) { return; }
            if (ValidarFechaNacimiento() == false) { return; }
            MessageBox.Show("Cliente registrado");

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
        //validar cedula 
        private bool ValidarCedula()
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                erpError.SetError(txtCedula, "Este campo no puede estar vacío");
                return false;
            }
            else
            {
                erpError.SetError(txtCedula, "");
                return true;
            }
        }
        //validar apellidos 
        private bool ValidarApellido()
        {
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                erpError.SetError(txtApellido, "Este campo no puede estar vacío");
                return false;
            }
            else
            {
                erpError.SetError(txtApellido, "");
                return true;
            }
        }
        //validar direccion

        private bool ValidarDireccion()
        {
            if (string.IsNullOrEmpty(txtDirDomiciliaria.Text))
            {
                erpError.SetError(txtDirDomiciliaria, "Este campo no puede estar vacío");
                return false;
            }
            else
            {
                erpError.SetError(txtDirDomiciliaria, "");
                return true;
            }
        }
        // calidar telefono de contacto 
        private bool ValidarTelefono()
        {
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                erpError.SetError(txtTelefono, "Este campo no puede estar vacío");
                return false;
            }
            else
            {
                erpError.SetError(txtTelefono, "");
                return true;
            }
        }
        //validar fecha de nacimiento
        private bool ValidarFechaNacimiento()
        {
            if (string.IsNullOrEmpty(dtpFecha.Text))
            {
                erpError.SetError(dtpFecha, "Este campo no puede estar vacío");
                return false;
            }
            else
            {
                erpError.SetError(dtpFecha, "");
                return true;
            }
        }
        //validar correo 
        private bool ValidarCorreo()
        {
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                erpError.SetError(txtCorreo, "Este campo no puede estar vacío");
                return false;
            }
            else
            {
                erpError.SetError(txtCorreo, "");
                return true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
