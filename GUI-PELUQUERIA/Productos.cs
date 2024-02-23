using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_PELUQUERIA
{
    public partial class Productos : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocios objneg = new ClaseNegocios();
       // List<ClsProductos> miLista = new List<ClsProductos>();
        public Productos()
        {
            InitializeComponent();

        }
        void mantenimiento(String action)
        {
            objent.numLote = txtnumLote.Text;
            objent.nombreP = txtNombre.Text;
            int precio;
            if (int.TryParse(txtPrecio.Text, out precio))
            {
                objent.precio = precio.ToString();
            }
            else
            {
                // Manejo del error si el valor no es un número entero válido
                MessageBox.Show("El valor ingresado en Precio no es válido. Por favor, ingrese un número entero válido.");
            }
            string fechaTexto = dtCaducidad.Value.ToString(); // Convertir a texto usando el formato predeterminado
            string fechaFormatoPersonalizado = dtCaducidad.Value.ToString("dd/MM/yyyy"); // Convertir a texto con formato personalizado

            objent.fechaCaducidad = fechaFormatoPersonalizado;
            string valorSeleccionado = cbTipo.SelectedItem.ToString();
            objent.tipo = valorSeleccionado;
            int stock;

           if (int.TryParse(txtStockMin.Text, out stock))
            {
                objent.stockMin = stock.ToString();
            }
            else
            {
                // Manejo del error si el valor no es un número entero válido
                MessageBox.Show("El valor ingresado en Stock no es válido. Por favor, ingrese un número entero válido.");
                return;
            }
            objent.action = action;
            String men = objneg.N_mantenimiento_producto(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (ValidarNombre() == false) { return; }
              if (ValidarPrecio() == false) { return; }
              //creamos un objeto de tipo lista 
            /*  ClsProductos miProducto = new ClsProductos();
              miProducto.Nombre = txtNombre.Text;
              miProducto.Precio = txtPrecio.Text;
              miProducto.FechaCaducidad = dtCaducidad.Text;
              miProducto.StockInicial = txtStockMin.Text;
              miProducto.Tipo = Convert.ToString(cbTipo.SelectedItem);
              miLista.Add(miProducto);
              dgvProductos.DataSource = null;
              dgvProductos.DataSource = miLista;
              LimpiarControles();
              txtNombre.Focus();*/
            if (txtnumLote.Text == "")
            {
                if (MessageBox.Show("Desea registrar a" + txtNombre.Text + "?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    LimpiarControles();
                }
            }


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
            txtnumLote.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStockMin.Text="";
            cbTipo.SelectedIndex = 0;
            dgvProductos.DataSource = objneg.N_listar_productos();

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
            dgvProductos.DataSource = objneg.N_listar_productos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }

            else
            {
                erpError.SetError(txtNombre, "");


            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
   
            if (txtnumLote.Text != "")
            {
                if (MessageBox.Show("Desea actualizar a" + txtNombre.Text + "?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    LimpiarControles();
                }
            }
            else
            {
                
                MessageBox.Show("Debe seleccionar un registro de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            cbTipo.Enabled = true;
            dtCaducidad.Enabled = true; 
            LimpiarControles();
            txtNombre.Focus();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvProductos.CurrentCell.RowIndex;

            txtnumLote.Text = dgvProductos[0, fila].Value.ToString();
            txtNombre.Text = dgvProductos[1, fila].Value.ToString();
            txtPrecio.Text = dgvProductos[2, fila].Value.ToString();
            dtCaducidad.Text = dgvProductos[3, fila].Value.ToString();
            txtStockMin.Text = dgvProductos[4, fila].Value.ToString();
            cbTipo.Text = dgvProductos[5, fila].Value.ToString();
            txtNombre.Enabled=false; 
            dtCaducidad.Enabled=false;
            cbTipo.Enabled=false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            if (txtnumLote.Text != "")
            {
                if (MessageBox.Show("Desea eliminar a" + txtNombre.Text + "?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    LimpiarControles();
                }
            }
            else
            {
             MessageBox.Show("Debe seleccionar un registro de la lista a eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtConsultar.Text != "")
            {
                objent.nombreP = txtConsultar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_productos(objent);
                dgvProductos.DataSource = dt;
            }
            else
            {
                dgvProductos.DataSource = objneg.N_listar_productos();
            }
        }
        
    }
}
