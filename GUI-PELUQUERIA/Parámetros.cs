using Capa_Entidad;
using Capa_Negocios;
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
    public partial class Parámetros : Form
    {
        Parametros objent = new Parametros();
        ClaseNegocios objneg = new ClaseNegocios();
        public Parámetros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //validar el iva
        private bool ValidarIva()
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Los campos no puedes estar vacíos");
                return false;
            }
            else
            {
                return true;
            }
        }

        void mantenimiento(String action)
        {

            objent.NombreParametro = txtParametro.Text;
            objent.ValorParametro = txtValor.Text;

            objent.action = action;
            String men = objneg.N_mantenimiento_parametros(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void button4_Click(object sender, EventArgs e)
        {

            if (txtValor.Text != "")
            {
                if (MessageBox.Show("¿Desea actualizar a el valor a " + txtValor.Text + "?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    dgParametros.Refresh();
                }
            }
            else
            {

                MessageBox.Show("Debe seleccionar un registro de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgParametros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgParametros.CurrentCell.RowIndex;
            txtParametro.Text = dgParametros[1, fila].Value.ToString();
            txtValor.Text = dgParametros[2, fila].Value.ToString();
        }

        private void Parámetros_Load(object sender, EventArgs e)
        {
            dgParametros.DataSource = objneg.N_listar_parametros();
            int fila = dgParametros.CurrentCell.RowIndex;
            txtParametro.Text = dgParametros[1, fila].Value.ToString();
            txtValor.Text = dgParametros[2, fila].Value.ToString();
        }

        private void Parametros(object sender, EventArgs e)
        {

        }
    }
}
