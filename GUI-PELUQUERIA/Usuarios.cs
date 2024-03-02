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
    public partial class Usuarios : Form
    {
        Conexion c = new Conexion();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            btActualizar.Hide();
            btEliminar.Hide();
            c.llenarT("usuario", dataGridView1);
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (validarU() == false) { MessageBox.Show("Usuario no valido"); return; }
            if (validarC() == false) { MessageBox.Show("Contraseña invalida"); return; }
            if (c.validarU(textUsuario.Text, textContra.Text) > 0)
            {
                MessageBox.Show("Usuario ya registraado");
                textUsuario.Text = "";
                textContra.Text = "";
                return;
            }
            else
            {
                MessageBox.Show(c.insertarU(textUsuario.Text, textContra.Text));
                c.llenarT("usuario", dataGridView1);
                textUsuario.Text = "";
                textContra.Text = "";
            }
        }
        private bool validarU()
        {
            bool validar = true;
            if (textUsuario.Text == "")
            {
                validar = false;
            }
            return validar;
        }
        private bool validarC()
        {
            bool validar = true;
            if (textContra.Text == "" || textContra.Text.Length <= 7 || textContra.Text.Length >= 9)
            {
                validar = false;
            }
            return validar;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            textUsuario.Text = "";
            textContra.Text = "";
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (validarU() == false) { MessageBox.Show("Usuario no valido"); return; }
            if (c.validarCU(textUsuario.Text) > 0)
            {
                c.llenarConsultaU(textUsuario.Text, textContra);
                textUsuario.Enabled = false;
                btActualizar.Show();
                btEliminar.Show();
            }
            else
            {
                MessageBox.Show("No existe este usuario");
                textUsuario.Text = "";
                textContra.Text = "";
            }

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (validarC() == false) { MessageBox.Show("Contraseña invalida"); return; }
            MessageBox.Show(c.actualizarU(textUsuario.Text, textContra.Text));
            c.llenarT("usuario", dataGridView1);
            textUsuario.Text = "";
            textContra.Text = "";
            textUsuario.Enabled = true;
            btActualizar.Hide();
            btEliminar.Hide();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.eliminarU(textUsuario.Text));
            c.llenarT("usuario", dataGridView1);
            textUsuario.Text = "";
            textContra.Text = "";
            textUsuario.Enabled = true;
            btEliminar.Hide();
            btActualizar.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
