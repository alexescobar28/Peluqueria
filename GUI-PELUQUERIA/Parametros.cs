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
    public partial class Parametros : Form
    {
        Conexion c = new Conexion();
        public Parametros()
        {
            InitializeComponent();
        }

        private void Parametros_Load(object sender, EventArgs e)
        {
            c.llenarPara(txtIVA, txtMoneda);
            c.llenarT("parametros", dataGridView1);
        }
        private bool validarI()
        {
            int num;
            bool validar = int.TryParse(txtIVA.Text, out num);
            return validar;
        }

        private void btIVA_Click(object sender, EventArgs e)
        {
            if (validarI() == false) { MessageBox.Show("IVA invalido"); return; }
            if (String.IsNullOrEmpty(txtIVA.Text)) { MessageBox.Show("No puede dejar vacio el campo");return; }
            MessageBox.Show(c.actualizarP("IVA", txtIVA.Text));
            c.llenarT("parametros", dataGridView1);
            c.llenarPara(txtIVA, txtMoneda);
        }

        private void btMoneda_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMoneda.Text))
            {
                MessageBox.Show("No puede dejar el campo vacio");
            }
            else
            {
                MessageBox.Show(c.actualizarP("moneda", txtMoneda.Text));
                c.llenarT("parametros", dataGridView1);
                c.llenarPara(txtIVA, txtMoneda);
            }
            
        }
    }
}
