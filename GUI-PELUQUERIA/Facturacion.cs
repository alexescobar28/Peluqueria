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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            if(Convert.ToString(comboBox1.SelectedItem)=="Venta de Producto")
            {
                StockAgregar agregarProducto = new StockAgregar();
                agregarProducto.Show();
            }
            else
            {
                MessageBox.Show("Se deberia agregar al grid");
            }
            
        }

        
    }
}
