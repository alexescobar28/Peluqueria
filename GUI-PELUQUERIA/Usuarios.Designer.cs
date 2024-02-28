namespace GUI_PELUQUERIA
{
    partial class Usuarios
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
            dtgvUsuarios = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btLimpiar = new Button();
            btActualizar = new Button();
            btConsultar = new Button();
            btRegistrar = new Button();
            textContra = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textUsuario = new TextBox();
            label3 = new Label();
            txtidUsuario = new TextBox();
            erpUsuario = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dtgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpUsuario).BeginInit();
            SuspendLayout();
            // 
            // dtgvUsuarios
            // 
            dtgvUsuarios.AllowUserToAddRows = false;
            dtgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUsuarios.Location = new Point(447, 257);
            dtgvUsuarios.MultiSelect = false;
            dtgvUsuarios.Name = "dtgvUsuarios";
            dtgvUsuarios.ReadOnly = true;
            dtgvUsuarios.Size = new Size(417, 218);
            dtgvUsuarios.TabIndex = 0;
            dtgvUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btLimpiar);
            groupBox1.Controls.Add(btActualizar);
            groupBox1.Controls.Add(btConsultar);
            groupBox1.Controls.Add(btRegistrar);
            groupBox1.Controls.Add(textContra);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textUsuario);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(364, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 171);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(330, 128);
            button1.Name = "button1";
            button1.Size = new Size(78, 25);
            button1.TabIndex = 8;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.ForeColor = Color.Black;
            btLimpiar.Location = new Point(185, 127);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(83, 26);
            btLimpiar.TabIndex = 7;
            btLimpiar.Text = "Limpiar";
            btLimpiar.UseVisualStyleBackColor = true;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // btActualizar
            // 
            btActualizar.ForeColor = Color.Black;
            btActualizar.Location = new Point(445, 126);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(82, 27);
            btActualizar.TabIndex = 6;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // btConsultar
            // 
            btConsultar.ForeColor = Color.Black;
            btConsultar.Location = new Point(494, 29);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(78, 27);
            btConsultar.TabIndex = 5;
            btConsultar.Text = "Consultar";
            btConsultar.UseVisualStyleBackColor = true;
            btConsultar.Click += btConsultar_Click;
            // 
            // btRegistrar
            // 
            btRegistrar.ForeColor = Color.Black;
            btRegistrar.Location = new Point(83, 128);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(66, 25);
            btRegistrar.TabIndex = 4;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // textContra
            // 
            textContra.Location = new Point(83, 89);
            textContra.Name = "textContra";
            textContra.Size = new Size(385, 23);
            textContra.TabIndex = 3;
            textContra.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 92);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(83, 29);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(385, 23);
            textUsuario.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(577, 9);
            label3.Name = "label3";
            label3.Size = new Size(304, 32);
            label3.TabIndex = 2;
            label3.Text = "Administración de Usuarios";
            // 
            // txtidUsuario
            // 
            txtidUsuario.Location = new Point(917, 45);
            txtidUsuario.Name = "txtidUsuario";
            txtidUsuario.Size = new Size(56, 23);
            txtidUsuario.TabIndex = 3;
            // 
            // erpUsuario
            // 
            erpUsuario.ContainerControl = this;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1027, 487);
            Controls.Add(txtidUsuario);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(dtgvUsuarios);
            ForeColor = Color.FromArgb(49, 66, 82);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvUsuarios;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textUsuario;
        private TextBox textContra;
        private Label label2;
        private Button btActualizar;
        private Button btConsultar;
        private Button btRegistrar;
        private Button btLimpiar;
        private Button button1;
        private Label label3;
        private TextBox txtidUsuario;
        private ErrorProvider erpUsuario;
    }
}