﻿namespace GUI_PELUQUERIA
{
    partial class btnLimpiar
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
            button1 = new Button();
            btnActualizar = new Button();
            btnConsultar = new Button();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(634, 60);
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
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Location = new Point(488, 352);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 81);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // button1
            // 
            button1.Location = new Point(253, 35);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(354, 35);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button3_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(146, 35);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(488, 130);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(764, 130);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(488, 195);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Caducidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(764, 195);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(488, 264);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "Stock Min:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(488, 158);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(764, 158);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(207, 23);
            txtPrecio.TabIndex = 10;
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new Point(488, 298);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.Size = new Size(200, 23);
            txtStockMin.TabIndex = 12;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Cuidado del cabello", "Styling", "Coloración", "Accesorios para el cabello", "Tratamientos capilares especializados", "Productos para barbería", "Productos de higiene y desinfección" });
            cbTipo.Location = new Point(764, 227);
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
            dtCaducidad.Location = new Point(488, 224);
            dtCaducidad.Name = "dtCaducidad";
            dtCaducidad.Size = new Size(200, 23);
            dtCaducidad.TabIndex = 16;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(398, 439);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(616, 161);
            dgvProductos.TabIndex = 17;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnLimpiar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1386, 611);
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
            Name = "btnLimpiar";
            Text = "Productos";
            Load += Productos_Load_1;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrar;
        private GroupBox groupBox1;
        private Button btnActualizar;
        private Button btnConsultar;
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
    }
}