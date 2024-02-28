using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using Capa_Entidad;
namespace GUI_PELUQUERIA
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        Usuario objent = new Usuario();
        ClaseNegocios objneg = new ClaseNegocios();
        void mantenimiento(String action)
        {
            objent.nombre = textUsuario.Text;
            objent.contraseña = textContra.Text;
            objent.idUsuaro = Convert.ToInt32(txtidUsuario.Text);
            objent.action = action;
            String men = objneg.N_mantenimiento_usuarios(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void LimpiarControles()
        {
            textUsuario.Text = "";
            textContra.Text = "";
            txtidUsuario.Text = "";
            dtgvUsuarios.DataSource = objneg.N_listar_usuarios();


        }

        //validar el usuario
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(textUsuario.Text))
            {
                erpUsuario.SetError(textUsuario, "Usuario no válido \n");
                return false;
            }
            else
            {
                erpUsuario.SetError(textUsuario, "");
                return true;
            }
        }
        //validar el contrase;a
        private bool ValidarContrasenia()
        {
            if (string.IsNullOrEmpty(textContra.Text))
            {
                erpUsuario.SetError(textContra, "Contraseña no válido \n");
                return false;
            }
            else
            {
                erpUsuario.SetError(textContra, "");
                return true;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dtgvUsuarios.CurrentCell.RowIndex;

            txtidUsuario.Text = dtgvUsuarios[0, fila].Value.ToString();
            textUsuario.Text = dtgvUsuarios[1, fila].Value.ToString();
            textContra.Text = dtgvUsuarios[2, fila].Value.ToString();

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

            /*  List<Usuario> usuarios = new CN_Usuario().listar();
              foreach (Usuario item in usuarios)
              {
                  dtgvUsuarios.Rows.Add(new object[] { item.idUsuaro, item.nombre, item.contraseña });
              }
            */
            dtgvUsuarios.DataSource = objneg.N_listar_usuarios();

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false) { return; };
            if (ValidarContrasenia() == false) { return; }

            /* string mensaje = string.Empty;
             Usuario objusuario = new Usuario()
             {
                 idUsuaro = Convert.ToInt32(txtidUsuario.Text),
                 nombre = textUsuario.Text,
                 contraseña = textContra.Text,
             };
             if (objusuario.idUsuaro == 0)
             {
                 int idUsuarioRegistrado = new CN_Usuario().Registrar(objusuario, out mensaje);
                 if (idUsuarioRegistrado != -1)
                 {
                     MessageBox.Show("Usuario registrado existosamente");
                     dtgvUsuarios.Rows.Add(new object[] { idUsuarioRegistrado, textUsuario.Text, textContra.Text });
                     LimpiarControles();
                 }
                 else
                 {
                     MessageBox.Show("No se pudo registar");
                 }
             }
             else
             {

             }
             LimpiarControles();*/

            if (txtidUsuario.Text == "")
            {
                if (MessageBox.Show("Desea registrar a" + textUsuario.Text + "?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    LimpiarControles();
                }
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false) { return; };
            if (ValidarContrasenia() == false) { return; }

            /* string mensaje = string.Empty;
             Usuario objusuario = new Usuario();
             bool resultado = new CN_Usuario().Actualizar(objusuario, out mensaje);
             if (!resultado)
             {
                 DataGridViewRow row = dtgvUsuarios.Rows[Convert.ToInt32(txtidUsuario.Text)];
                 row.Cells["Nombre"].Value = textUsuario.Text.Trim();
                 row.Cells["Contraseña"].Value = textContra.Text.Trim();
                 LimpiarControles();
             }
             else
             {

                 MessageBox.Show("No se pudieron actulizar los datos");

                 }*/
            if (txtidUsuario.Text != "")
            {
                if (MessageBox.Show("Desea actualizar a" + textUsuario.Text + "?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    LimpiarControles();
                    return;
                }
            }
            else
            {

                MessageBox.Show("Debe seleccionar un registro de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (txtidUsuario.Text != "")
            {
                if (MessageBox.Show("Desea eliminar a" + textUsuario.Text + "?", "Message",
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

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != "")
            {
                objent.nombre = textUsuario.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_usuarios(objent);
                dtgvUsuarios.DataSource = dt;
            }
            else
            {
                dtgvUsuarios.DataSource = objneg.N_listar_productos();
            }
        }
    }
}
