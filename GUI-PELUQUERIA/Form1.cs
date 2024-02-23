namespace GUI_PELUQUERIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            customizeDesign();
            AbrirFormHija(new Inicio());
        }
        int m, mx, my;
        private void customizeDesign()
        {
            panelSubProductos.Visible = false;
            panelSubVentas.Visible = false;
            panelSubAdmin.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubProductos.Visible == true)
            {
                panelSubProductos.Visible = false;
            }
            if (panelSubVentas.Visible == true) { panelSubVentas.Visible = false; }
            if (panelSubAdmin.Visible == true) { panelSubAdmin.Visible = false; }

        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;

            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMax.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelSubVentas.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelSubVentas.Visible = false;

        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();


        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubProductos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Clientes());
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Agenda());
        }

        private void btnAdministración_Click(object sender, EventArgs e)
        {

        }



        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Stock());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            panelSubAdmin.Visible = true;

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            panelSubVentas.Visible = false;
            AbrirFormHija(new Facturacion());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Inicio());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormHija(new Productos());
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormHija(new Herramientas());
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Inicio());
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Clientes());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgenda_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Agenda());
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Administracion());
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            panelSubVentas.Visible = true;
        }

        private void BarraTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitle_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void BarraTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void BarraTitle_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();

        }

        private void btnAdministracion_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Stock());
        }

        private void btnAusuarios_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAparametros_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
