namespace GUI_PELUQUERIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelContenedor = new Panel();
            button1 = new Button();
            btnInicio = new Button();
            BarraMenu = new Panel();
            panelSubVentas = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            button7 = new Button();
            btnFacturacion = new Button();
            btnVentas = new Button();
            btnAdministracion = new Button();
            btnAgenda = new Button();
            btnClientes = new Button();
            panelSubProductos = new Panel();
            btnProductos = new Button();
            btnHerramientas = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btnProductosHerramientas = new Button();
            panelLogo = new Panel();
            btnCerrar = new PictureBox();
            btnMin = new PictureBox();
            btnMax = new PictureBox();
            btnRestaurar = new PictureBox();
            BarraTitle = new Panel();
            button2 = new Button();
            panelContenedor.SuspendLayout();
            BarraMenu.SuspendLayout();
            panelSubVentas.SuspendLayout();
            panelSubProductos.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            BarraTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Controls.Add(button1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1300, 600);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = SystemColors.MenuHighlight;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.TopCenter;
            btnInicio.Location = new Point(3, 6);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(197, 117);
            btnInicio.TabIndex = 17;
            btnInicio.Text = "INICIO";
            btnInicio.TextAlign = ContentAlignment.BottomCenter;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click_1;
            // 
            // BarraMenu
            // 
            BarraMenu.AutoScroll = true;
            BarraMenu.BackColor = Color.FromArgb(26, 32, 40);
            BarraMenu.Controls.Add(button2);
            BarraMenu.Controls.Add(panelSubVentas);
            BarraMenu.Controls.Add(btnVentas);
            BarraMenu.Controls.Add(btnAdministracion);
            BarraMenu.Controls.Add(btnAgenda);
            BarraMenu.Controls.Add(btnClientes);
            BarraMenu.Controls.Add(panelSubProductos);
            BarraMenu.Controls.Add(btnProductosHerramientas);
            BarraMenu.Controls.Add(panelLogo);
            BarraMenu.Dock = DockStyle.Left;
            BarraMenu.Location = new Point(0, 50);
            BarraMenu.Name = "BarraMenu";
            BarraMenu.Size = new Size(200, 600);
            BarraMenu.TabIndex = 3;
            // 
            // panelSubVentas
            // 
            panelSubVentas.Controls.Add(panel5);
            panelSubVentas.Controls.Add(panel4);
            panelSubVentas.Controls.Add(button7);
            panelSubVentas.Controls.Add(btnFacturacion);
            panelSubVentas.Dock = DockStyle.Top;
            panelSubVentas.Location = new Point(0, 366);
            panelSubVentas.Name = "panelSubVentas";
            panelSubVentas.Size = new Size(200, 77);
            panelSubVentas.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(35, 46);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 32);
            panel5.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(35, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 32);
            panel4.TabIndex = 6;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(32, 8);
            button7.Name = "button7";
            button7.Size = new Size(168, 28);
            button7.TabIndex = 17;
            button7.Text = "Stock";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // btnFacturacion
            // 
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.ForeColor = Color.White;
            btnFacturacion.Location = new Point(32, 42);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(168, 28);
            btnFacturacion.TabIndex = 15;
            btnFacturacion.Text = "Facturación";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 334);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(200, 32);
            btnVentas.TabIndex = 25;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click_1;
            // 
            // btnAdministracion
            // 
            btnAdministracion.Dock = DockStyle.Top;
            btnAdministracion.FlatAppearance.BorderSize = 0;
            btnAdministracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAdministracion.FlatStyle = FlatStyle.Flat;
            btnAdministracion.ForeColor = Color.White;
            btnAdministracion.Location = new Point(0, 302);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Size = new Size(200, 32);
            btnAdministracion.TabIndex = 24;
            btnAdministracion.Text = "Administración";
            btnAdministracion.UseVisualStyleBackColor = true;
            btnAdministracion.Click += btnAdministracion_Click;
            // 
            // btnAgenda
            // 
            btnAgenda.Dock = DockStyle.Top;
            btnAgenda.FlatAppearance.BorderSize = 0;
            btnAgenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.ForeColor = Color.White;
            btnAgenda.Location = new Point(0, 270);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(200, 32);
            btnAgenda.TabIndex = 23;
            btnAgenda.Text = "Agenda";
            btnAgenda.UseVisualStyleBackColor = true;
            btnAgenda.Click += btnAgenda_Click_1;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 238);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(200, 32);
            btnClientes.TabIndex = 22;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click_1;
            // 
            // panelSubProductos
            // 
            panelSubProductos.Controls.Add(btnProductos);
            panelSubProductos.Controls.Add(btnHerramientas);
            panelSubProductos.Controls.Add(panel2);
            panelSubProductos.Controls.Add(panel1);
            panelSubProductos.Dock = DockStyle.Top;
            panelSubProductos.Location = new Point(0, 161);
            panelSubProductos.Name = "panelSubProductos";
            panelSubProductos.Size = new Size(200, 77);
            panelSubProductos.TabIndex = 21;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(35, 3);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(165, 32);
            btnProductos.TabIndex = 18;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnHerramientas
            // 
            btnHerramientas.FlatAppearance.BorderSize = 0;
            btnHerramientas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnHerramientas.FlatStyle = FlatStyle.Flat;
            btnHerramientas.ForeColor = Color.White;
            btnHerramientas.Location = new Point(35, 43);
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.Size = new Size(165, 28);
            btnHerramientas.TabIndex = 20;
            btnHerramientas.Text = "Herramientas";
            btnHerramientas.UseVisualStyleBackColor = true;
            btnHerramientas.Click += btnHerramientas_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(32, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 32);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(32, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 32);
            panel1.TabIndex = 5;
            // 
            // btnProductosHerramientas
            // 
            btnProductosHerramientas.Dock = DockStyle.Top;
            btnProductosHerramientas.FlatAppearance.BorderSize = 0;
            btnProductosHerramientas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProductosHerramientas.FlatStyle = FlatStyle.Flat;
            btnProductosHerramientas.ForeColor = Color.White;
            btnProductosHerramientas.Location = new Point(0, 129);
            btnProductosHerramientas.Name = "btnProductosHerramientas";
            btnProductosHerramientas.Size = new Size(200, 32);
            btnProductosHerramientas.TabIndex = 1;
            btnProductosHerramientas.Text = "Productos y Herramientas";
            btnProductosHerramientas.UseVisualStyleBackColor = true;
            btnProductosHerramientas.Click += btnProductos_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnInicio);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 129);
            panelLogo.TabIndex = 16;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1243, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 34);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(1141, 3);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(45, 34);
            btnMin.SizeMode = PictureBoxSizeMode.Zoom;
            btnMin.TabIndex = 1;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(1192, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(45, 34);
            btnMax.SizeMode = PictureBoxSizeMode.Zoom;
            btnMax.TabIndex = 2;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1192, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(45, 34);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // BarraTitle
            // 
            BarraTitle.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitle.Controls.Add(btnRestaurar);
            BarraTitle.Controls.Add(btnMax);
            BarraTitle.Controls.Add(btnMin);
            BarraTitle.Controls.Add(btnCerrar);
            BarraTitle.Dock = DockStyle.Top;
            BarraTitle.Location = new Point(0, 0);
            BarraTitle.Name = "BarraTitle";
            BarraTitle.Size = new Size(1300, 50);
            BarraTitle.TabIndex = 1;
            BarraTitle.Paint += BarraTitle_Paint;
            BarraTitle.MouseDown += BarraTitle_MouseDown;
            BarraTitle.MouseMove += BarraTitle_MouseMove;
            BarraTitle.MouseUp += BarraTitle_MouseUp;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 575);
            button2.Name = "button2";
            button2.Size = new Size(200, 25);
            button2.TabIndex = 26;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(BarraMenu);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panelContenedor.ResumeLayout(false);
            BarraMenu.ResumeLayout(false);
            panelSubVentas.ResumeLayout(false);
            panelSubProductos.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            BarraTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenedor;
        private Panel BarraMenu;
        private Button button7;
        private Button btnFacturacion;
        private Button btnVentas;
        private Panel panel2;
        private Panel panel1;
        private Button btnProductosHerramientas;
        private Button button1;
        private PictureBox btnCerrar;
        private PictureBox btnMin;
        private PictureBox btnMax;
        private PictureBox btnRestaurar;
        private Panel BarraTitle;
        private Button btnProductos;
        private Panel panelLogo;
        private Button btnHerramientas;
        private Button btnInicio;
        private Button btnClientes;
        private Panel panelSubProductos;
        private Button btnAdministración;
        private Button btnAdministracion;
        private Button btnAgenda;
        private Panel panelSubVentas;
        private Panel panel5;
        private Panel panel4;
        private Button button2;
    }
}
