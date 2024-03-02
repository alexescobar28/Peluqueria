namespace GUI_PELUQUERIA
{
    partial class Clientes
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtCedula = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtDirDomiciliaria = new TextBox();
            txtEnfermedades = new TextBox();
            txtNombre = new TextBox();
            txtAlergias = new TextBox();
            txtCorreo = new TextBox();
            txtPreferencias = new TextBox();
            label8 = new Label();
            cbEstadoCivil = new ComboBox();
            cbSexo = new ComboBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            btnEliminar = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            erpError = new ErrorProvider(components);
            dtpFecha = new DateTimePicker();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label15 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(598, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 2;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(350, 58);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Cédula:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(838, 58);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(838, 119);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 5;
            label4.Text = "Dirección Domiciliaria";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(838, 178);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(591, 58);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 7;
            label6.Text = "Nombres:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(353, 111);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 8;
            label7.Text = "Teléfono de Contacto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(591, 111);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 10;
            label9.Text = "Fecha Nacimiento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(350, 178);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 11;
            label10.Text = "Estado Civil";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(591, 178);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 12;
            label11.Text = "Sexo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(591, 248);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 13;
            label12.Text = "Alergias";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(350, 248);
            label13.Name = "label13";
            label13.Size = new Size(133, 15);
            label13.TabIndex = 14;
            label13.Text = "Enfermedades Capilares";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(352, 76);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(215, 23);
            txtCedula.TabIndex = 16;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(353, 138);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 23);
            txtTelefono.TabIndex = 17;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(591, 76);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(213, 23);
            txtApellido.TabIndex = 18;
            // 
            // txtDirDomiciliaria
            // 
            txtDirDomiciliaria.Location = new Point(838, 137);
            txtDirDomiciliaria.Name = "txtDirDomiciliaria";
            txtDirDomiciliaria.Size = new Size(217, 23);
            txtDirDomiciliaria.TabIndex = 19;
            // 
            // txtEnfermedades
            // 
            txtEnfermedades.Location = new Point(838, 266);
            txtEnfermedades.Name = "txtEnfermedades";
            txtEnfermedades.Size = new Size(217, 23);
            txtEnfermedades.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(838, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(217, 23);
            txtNombre.TabIndex = 21;
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(350, 266);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(217, 23);
            txtAlergias.TabIndex = 22;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(838, 206);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(217, 23);
            txtCorreo.TabIndex = 23;
            // 
            // txtPreferencias
            // 
            txtPreferencias.Location = new Point(587, 266);
            txtPreferencias.Name = "txtPreferencias";
            txtPreferencias.Size = new Size(217, 23);
            txtPreferencias.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(838, 248);
            label8.Name = "label8";
            label8.Size = new Size(139, 15);
            label8.TabIndex = 26;
            label8.Text = "Preferencias de Producto";
            // 
            // cbEstadoCivil
            // 
            cbEstadoCivil.FormattingEnabled = true;
            cbEstadoCivil.Items.AddRange(new object[] { "Soltero", "Casado", "Divorciado", "Viudo ", "Unión Libre" });
            cbEstadoCivil.Location = new Point(352, 206);
            cbEstadoCivil.Name = "cbEstadoCivil";
            cbEstadoCivil.Size = new Size(215, 23);
            cbEstadoCivil.TabIndex = 27;
            cbEstadoCivil.Text = "Soltero";
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino ", "Femenino" });
            cbSexo.Location = new Point(591, 206);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(213, 23);
            cbSexo.TabIndex = 28;
            cbSexo.Text = "Masculino ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(414, 295);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 81);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Activo ", "Inactivo" });
            comboBox1.Location = new Point(348, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Activo";
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(487, 36);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Cambiar Estado";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(118, 35);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(217, 35);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(30, 35);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(591, 134);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(213, 23);
            dtpFecha.TabIndex = 30;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label15);
            groupBox2.Location = new Point(455, 382);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 62);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 23);
            textBox1.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(31, 30);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 0;
            label15.Text = "Cédula";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 459);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(737, 88);
            dataGridView1.TabIndex = 32;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1266, 629);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(dtpFecha);
            Controls.Add(groupBox1);
            Controls.Add(cbSexo);
            Controls.Add(cbEstadoCivil);
            Controls.Add(label8);
            Controls.Add(txtPreferencias);
            Controls.Add(txtCorreo);
            Controls.Add(txtAlergias);
            Controls.Add(txtNombre);
            Controls.Add(txtEnfermedades);
            Controls.Add(txtDirDomiciliaria);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            Text = "Clientes";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtCedula;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtDirDomiciliaria;
        private TextBox txtEnfermedades;
        private TextBox txtNombre;
        private TextBox txtAlergias;
        private TextBox txtCorreo;
        private TextBox txtPreferencias;
        private Label label8;
        private ComboBox cbEstadoCivil;
        private ComboBox cbSexo;
        private GroupBox groupBox1;
        private Button button1;
        private ErrorProvider erpError;
        private DateTimePicker dtpFecha;
        private Button btnEliminar;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label15;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
    }
}