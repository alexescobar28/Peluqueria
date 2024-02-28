namespace GUI_PELUQUERIA
{
    partial class Parámetros
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtParametro = new TextBox();
            dgParametros = new DataGridView();
            txtValor = new TextBox();
            label5 = new Label();
            label4 = new Label();
            button4 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgParametros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(588, 36);
            label1.Name = "label1";
            label1.Size = new Size(332, 32);
            label1.TabIndex = 0;
            label1.Text = "Administración de Parámetros";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtParametro);
            groupBox2.Controls.Add(dgParametros);
            groupBox2.Controls.Add(txtValor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(380, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(495, 260);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parámetros";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtParametro
            // 
            txtParametro.Location = new Point(32, 51);
            txtParametro.Name = "txtParametro";
            txtParametro.Size = new Size(216, 23);
            txtParametro.TabIndex = 12;
            txtParametro.Text = "Porcentaje de iva";
            // 
            // dgParametros
            // 
            dgParametros.AllowUserToAddRows = false;
            dgParametros.AllowUserToDeleteRows = false;
            dgParametros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgParametros.Location = new Point(89, 100);
            dgParametros.MultiSelect = false;
            dgParametros.Name = "dgParametros";
            dgParametros.ReadOnly = true;
            dgParametros.Size = new Size(358, 105);
            dgParametros.TabIndex = 11;
            dgParametros.CellContentClick += dgParametros_CellContentClick;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(296, 51);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(193, 23);
            txtValor.TabIndex = 9;
            txtValor.Text = "12%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(308, 18);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 8;
            label5.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 19);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Parámetros";
            label4.Click += Parametros;
            // 
            // button4
            // 
            button4.Location = new Point(219, 231);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Actualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Parámetros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(945, 450);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Parámetros";
            Text = "Parámetros";
            Load += Parámetros_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgParametros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtValor;
        private Label label5;
        private Label label4;
        private Button button4;
        private DataGridView dgParametros;
        private TextBox txtParametro;
    }
}