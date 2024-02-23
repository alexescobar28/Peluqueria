using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GUI_PELUQUERIA
{
    
    public partial class Login : Form
    {
        static string conexionstring= "server = LAPTOP-MQ2NT5FG; database =Peluqueria; Integrated Security=True";
        SqlConnection connection=new SqlConnection(conexionstring);
        
        public Login()
        {
            InitializeComponent();
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario" && txtPassword.Text == "1234")
            {
                Form1 menu = new Form1();
                this.Hide();
                menu.Show();
          
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtUser.Clear();
                txtPassword.Clear();
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }
    }
}
