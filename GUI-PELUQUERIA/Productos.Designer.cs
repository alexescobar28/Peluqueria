namespace GUI_PELUQUERIA
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnRegistrar = new Button();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            button1 = new Button();
            btnActualizar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStockMin = new TextBox();
            cbTipo = new ComboBox();
            erpError = new ErrorProvider(components);
            dtCaducidad = new DateTimePicker();
            dgvProductos = new DataGridView();
            groupBox2 = new GroupBox();
            label9 = new Label();
            txtConsultar = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtnumLote = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(714, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(30, 35);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Location = new Point(518, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 81);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(363, 35);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(144, 35);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(250, 35);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(518, 79);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(794, 79);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 5;
            label3.Text = "Precio Unitario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(518, 144);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Caducidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(794, 144);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(518, 213);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "Stock Min:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(518, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(794, 107);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(207, 23);
            txtPrecio.TabIndex = 10;
            txtPrecio.Text = "0";
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new Point(518, 247);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.Size = new Size(200, 23);
            txtStockMin.TabIndex = 12;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Cuidado del cabello", "Styling", "Coloración", "Accesorios para el cabello", "Tratamientos capilares especializados", "Productos para barbería", "Productos de higiene y desinfección" });
            cbTipo.Location = new Point(794, 176);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(207, 23);
            cbTipo.TabIndex = 14;
            cbTipo.Text = "Cuidado del cabello";
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // dtCaducidad
            // 
            dtCaducidad.Format = DateTimePickerFormat.Short;
            dtCaducidad.Location = new Point(518, 173);
            dtCaducidad.Name = "dtCaducidad";
            dtCaducidad.Size = new Size(200, 23);
            dtCaducidad.TabIndex = 16;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(483, 438);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(616, 161);
            dgvProductos.TabIndex = 17;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtConsultar);
            groupBox2.Location = new Point(517, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 68);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(31, 31);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 22;
            label9.Text = "Nombre: ";
            // 
            // txtConsultar
            // 
            txtConsultar.Location = new Point(95, 23);
            txtConsultar.Name = "txtConsultar";
            txtConsultar.Size = new Size(270, 23);
            txtConsultar.TabIndex = 3;
            txtConsultar.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 19;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(517, 51);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 20;
            label8.Text = "Lote: ";
            // 
            // txtnumLote
            // 
            txtnumLote.Enabled = false;
            txtnumLote.Location = new Point(570, 48);
            txtnumLote.Name = "txtnumLote";
            txtnumLote.Size = new Size(62, 23);
            txtnumLote.TabIndex = 21;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1386, 611);
            Controls.Add(txtnumLote);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(dgvProductos);
            Controls.Add(dtCaducidad);
            Controls.Add(cbTipo);
            Controls.Add(txtStockMin);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load_1;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrar;
        private GroupBox groupBox1;
        private Button btnActualizar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStockMin;
        private ComboBox cbTipo;
        private ErrorProvider erpError;
        private DateTimePicker dtCaducidad;
        private DataGridView dgvProductos;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox txtConsultar;
        private TextBox txtnumLote;
        private Label label8;
        private Label label7;
        private Label label9;
        private Button btnEliminar;
    }
}