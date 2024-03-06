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
        Conexion c = new Conexion();
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

            if (Convert.ToString(comboBox1.SelectedItem) == "Venta de Producto")
            {
                StockAgregar agregarProducto = new StockAgregar();
                DialogResult res = agregarProducto.ShowDialog();
                if (res == DialogResult.OK)
                {
                    AgregarVenta(agregarProducto.textBox1.Text, agregarProducto.textBox2.Text, Convert.ToDecimal(agregarProducto.textBox3.Text));
                }


            }
            else
            {
                dataGridView1.Rows.Add(comboBox1.SelectedItem.ToString(), txtCantidad.Text, Convert.ToDecimal(txtPrecio.Text));
            }

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            button5.Hide();
            c.llenarIVA(textBox4);
        }
        public void AgregarVenta(String pro, String cont, decimal cos)
        {
            dataGridView1.Rows.Add(pro, cont, cos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal cos = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                cos += decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            textBox5.Text = (cos * (1 + ((decimal.Parse(textBox4.Text)) / 100))).ToString();
            button5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quitar quitar = new Quitar();
            DialogResult res = quitar.ShowDialog();
            if (res == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == quitar.txtQuitar.Text)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.insertarFac(textBox1.Text,dateTimePicker1.Value.ToString("dd/MM/yyyy"),textBox5.Text));
            int idaux = c.validarFID();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                String nom = dataGridView1.Rows[i].Cells[0].Value.ToString();
                String can = dataGridView1.Rows[i].Cells[1].Value.ToString();
                String cos = dataGridView1.Rows[i].Cells[2].Value.ToString();
                if (nom!= "Corte"&& nom != "Tinturado" && nom != "Peinado")
                {
                    c.insertIt(idaux,nom,can,cos);
                    c.actINV(nom, int.Parse(can));
                }
                else
                {
                    c.insertIt(idaux, nom, can, cos);
                }
            }
        }
    }
}
