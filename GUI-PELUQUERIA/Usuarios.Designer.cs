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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btEliminar = new Button();
            btLimpiar = new Button();
            btActualizar = new Button();
            btConsultar = new Button();
            btRegistrar = new Button();
            textContra = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textUsuario = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(251, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(618, 218);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btEliminar);
            groupBox1.Controls.Add(btLimpiar);
            groupBox1.Controls.Add(btActualizar);
            groupBox1.Controls.Add(btConsultar);
            groupBox1.Controls.Add(btRegistrar);
            groupBox1.Controls.Add(textContra);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textUsuario);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(260, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 171);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // btEliminar
            // 
            btEliminar.ForeColor = Color.Black;
            btEliminar.Location = new Point(478, 128);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(94, 26);
            btEliminar.TabIndex = 8;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.ForeColor = Color.Black;
            btLimpiar.Location = new Point(240, 130);
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
            btActualizar.Location = new Point(365, 128);
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
            btRegistrar.Location = new Point(125, 130);
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
            textUsuario.Location = new Point(65, 29);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(403, 23);
            textUsuario.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(500, 35);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1100, 600);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            ForeColor = Color.FromArgb(49, 66, 82);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textUsuario;
        private TextBox textContra;
        private Label label2;
        private Button btActualizar;
        private Button btConsultar;
        private Button btRegistrar;
        private Button btLimpiar;
        private Label label3;
        private Button btEliminar;
    }
}