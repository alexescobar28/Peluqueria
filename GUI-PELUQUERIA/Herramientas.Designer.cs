namespace GUI_PELUQUERIA
{
    partial class Herramientas
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
            dtCaducidad = new DateTimePicker();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            cbEstado = new ComboBox();
            label6 = new Label();
            txtMarca = new TextBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            btnRegistrar = new Button();
            erpError = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // dtCaducidad
            // 
            dtCaducidad.Format = DateTimePickerFormat.Short;
            dtCaducidad.Location = new Point(416, 162);
            dtCaducidad.Name = "dtCaducidad";
            dtCaducidad.Size = new Size(200, 23);
            dtCaducidad.TabIndex = 26;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(692, 96);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(185, 23);
            txtPrecio.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(416, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 133);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 20;
            label4.Text = "Fecha de Adquisición";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(692, 68);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 19;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 68);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(545, 23);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 17;
            label1.Text = "Herramientas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(692, 130);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 27;
            label7.Text = "Estado:";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Buen Estado", "Necesita Reparación" });
            cbEstado.Location = new Point(692, 148);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(185, 23);
            cbEstado.TabIndex = 28;
            cbEstado.Text = "Buen Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 202);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 29;
            label6.Text = "Marca: ";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(416, 220);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(200, 23);
            txtMarca.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Location = new Point(416, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 81);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(331, 35);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(185, 35);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(30, 35);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // Herramientas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(935, 471);
            Controls.Add(groupBox1);
            Controls.Add(txtMarca);
            Controls.Add(label6);
            Controls.Add(cbEstado);
            Controls.Add(label7);
            Controls.Add(dtCaducidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Herramientas";
            Text = "Herramientas";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtCaducidad;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox cbEstado;
        private Label label6;
        private TextBox txtMarca;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button btnRegistrar;
        private ErrorProvider erpError;
    }
}