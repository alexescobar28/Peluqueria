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
            BarraMenu = new Panel();
            btnInicio = new Button();
            SubmenuVentas = new Panel();
            panel8 = new Panel();
            button7 = new Button();
            panel7 = new Panel();
            btnFacturacion = new Button();
            panel5 = new Panel();
            btnVentas = new Button();
            panel4 = new Panel();
            btnAdministración = new Button();
            panel3 = new Panel();
            btnAgenda = new Button();
            panel2 = new Panel();
            btnClientes = new Button();
            panel1 = new Panel();
            btnProductos = new Button();
            btnCerrar = new PictureBox();
            btnMin = new PictureBox();
            btnMax = new PictureBox();
            btnRestaurar = new PictureBox();
            BarraTitle = new Panel();
            panelContenedor.SuspendLayout();
            BarraMenu.SuspendLayout();
            SubmenuVentas.SuspendLayout();
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
            // BarraMenu
            // 
            BarraMenu.BackColor = Color.FromArgb(26, 32, 40);
            BarraMenu.Controls.Add(btnInicio);
            BarraMenu.Controls.Add(SubmenuVentas);
            BarraMenu.Controls.Add(panel5);
            BarraMenu.Controls.Add(btnVentas);
            BarraMenu.Controls.Add(panel4);
            BarraMenu.Controls.Add(btnAdministración);
            BarraMenu.Controls.Add(panel3);
            BarraMenu.Controls.Add(btnAgenda);
            BarraMenu.Controls.Add(panel2);
            BarraMenu.Controls.Add(btnClientes);
            BarraMenu.Controls.Add(panel1);
            BarraMenu.Controls.Add(btnProductos);
            BarraMenu.Dock = DockStyle.Left;
            BarraMenu.Location = new Point(0, 50);
            BarraMenu.Name = "BarraMenu";
            BarraMenu.Size = new Size(200, 600);
            BarraMenu.TabIndex = 3;
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
            btnInicio.Size = new Size(197, 128);
            btnInicio.TabIndex = 15;
            btnInicio.Text = "INICIO";
            btnInicio.TextAlign = ContentAlignment.BottomCenter;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // SubmenuVentas
            // 
            SubmenuVentas.Controls.Add(panel8);
            SubmenuVentas.Controls.Add(button7);
            SubmenuVentas.Controls.Add(panel7);
            SubmenuVentas.Controls.Add(btnFacturacion);
            SubmenuVentas.Location = new Point(32, 325);
            SubmenuVentas.Name = "SubmenuVentas";
            SubmenuVentas.Size = new Size(168, 71);
            SubmenuVentas.TabIndex = 14;
            SubmenuVentas.Visible = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(0, 37);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 28);
            panel8.TabIndex = 18;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 37);
            button7.Name = "button7";
            button7.Size = new Size(168, 28);
            button7.TabIndex = 17;
            button7.Text = "Stock";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 80, 200);
            panel7.Location = new Point(0, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(5, 28);
            panel7.TabIndex = 16;
            // 
            // btnFacturacion
            // 
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.ForeColor = Color.White;
            btnFacturacion.Location = new Point(0, 3);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(168, 28);
            btnFacturacion.TabIndex = 15;
            btnFacturacion.Text = "Facturación";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(0, 281);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 32);
            panel5.TabIndex = 13;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 281);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(197, 32);
            btnVentas.TabIndex = 12;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 243);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 32);
            panel4.TabIndex = 11;
            // 
            // btnAdministración
            // 
            btnAdministración.FlatAppearance.BorderSize = 0;
            btnAdministración.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAdministración.FlatStyle = FlatStyle.Flat;
            btnAdministración.ForeColor = Color.White;
            btnAdministración.Location = new Point(0, 243);
            btnAdministración.Name = "btnAdministración";
            btnAdministración.Size = new Size(197, 32);
            btnAdministración.TabIndex = 10;
            btnAdministración.Text = "Administración";
            btnAdministración.UseVisualStyleBackColor = true;
            btnAdministración.Click += btnAdministración_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 32);
            panel3.TabIndex = 9;
            // 
            // btnAgenda
            // 
            btnAgenda.FlatAppearance.BorderSize = 0;
            btnAgenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.ForeColor = Color.White;
            btnAgenda.Location = new Point(0, 205);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(197, 32);
            btnAgenda.TabIndex = 8;
            btnAgenda.Text = "Agenda";
            btnAgenda.UseVisualStyleBackColor = true;
            btnAgenda.Click += btnAgenda_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(0, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 32);
            panel2.TabIndex = 7;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 167);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(197, 32);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(0, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 32);
            panel1.TabIndex = 5;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 132);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(200, 32);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click_1;
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
            SubmenuVentas.ResumeLayout(false);
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
        private Panel SubmenuVentas;
        private Panel panel8;
        private Button button7;
        private Panel panel7;
        private Button btnFacturacion;
        private Panel panel5;
        private Button btnVentas;
        private Panel panel4;
        private Button btnAdministración;
        private Panel panel3;
        private Button btnAgenda;
        private Panel panel2;
        private Button btnClientes;
        private Panel panel1;
        private Button btnProductos;
        private Button button1;
        private Button btnInicio;
        private PictureBox btnCerrar;
        private PictureBox btnMin;
        private PictureBox btnMax;
        private PictureBox btnRestaurar;
        private Panel BarraTitle;
    }
}
