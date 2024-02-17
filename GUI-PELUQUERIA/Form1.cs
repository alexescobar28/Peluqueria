namespace GUI_PELUQUERIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AbrirFormHija(new Inicio());
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
            SubmenuVentas.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SubmenuVentas.Visible = false;

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
            AbrirFormHija(new Productos());
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
            AbrirFormHija(new Administracion());
        }



        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Stock());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            SubmenuVentas.Visible = false;
            AbrirFormHija(new Stock());
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            SubmenuVentas.Visible = false;
            AbrirFormHija(new Facturacion());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            SubmenuVentas.Visible = true;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Inicio());
        }
    }
}
