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
    public partial class Stock : Form
    {
        Conexion c=new Conexion();
        public Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.validarP(textBox1.Text) > 0)
            {
                c.llenarPT(textBox1.Text, dataGridView1);
            }
            else
            {
                MessageBox.Show("No existe producto");
            }
        }
    }
}
