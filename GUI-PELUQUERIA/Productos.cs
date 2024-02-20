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
    public partial class btnLimpiar : Form
    {
        List<ClsProductos> miLista = new List<ClsProductos>();
        public btnLimpiar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false) { return; }
            if (ValidarPrecio() == false) { return; }
            //creamos un objeto de tipo lista 
            ClsProductos miProducto = new ClsProductos();
            miProducto.Nombre = txtNombre.Text;
            miProducto.Precio = txtPrecio.Text;
            miProducto.FechaCaducidad = dtCaducidad.Text;
            miProducto.StockInicial = txtStockMin.Text;
            miProducto.Tipo = cbTipo.ToString();
            miLista.Add(miProducto);
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = miLista;
            LimpiarControles();
            txtNombre.Focus();

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
            txtStockMin.Clear();
            cbTipo.SelectedIndex = 0;

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

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void Productos_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            ClsProductos miProducto = GetMascota(txtNombre.Text);
            if (miProducto == null)
            {
                erpError.SetError(txtNombre, "El producto no esta registrado en la lista");
                LimpiarControles();
                txtNombre.Focus();
                return;

            }
            else
            {
                erpError.SetError(txtNombre, "");
                txtNombre.Text = miProducto.Nombre;
                cbTipo.SelectedItem = miProducto.Tipo;
                txtPrecio.Text = miProducto.Precio;
                txtStockMin.Text = miProducto.StockInicial;
                dtCaducidad.Text = miProducto.FechaCaducidad;

            }
        }
        //metodo obtener o consultar mascota
        private ClsProductos GetMascota(string nombre)
        {
            return miLista.Find(producto => producto.Nombre.Contains(nombre));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
            txtNombre.Focus();
        }
        //
    }
}
