namespace GUI_PELUQUERIA
{
    partial class Facturacion
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            btnConsultar = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            groupBox3 = new GroupBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox4 = new GroupBox();
            button5 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(564, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 2;
            label1.Text = "Factura";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(311, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 83);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Elegir Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 2;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(365, 34);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 37);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(311, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 308);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle  de la Venta";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(407, 117);
            dataGridView1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(330, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(365, 85);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Quitar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Corte", "Tinturado", "Peinado", "Venta de Producto" });
            comboBox1.Location = new Point(89, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(33, 85);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 31);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 39);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(25, 24);
            button3.Name = "button3";
            button3.Size = new Size(101, 48);
            button3.TabIndex = 5;
            button3.Text = "Consultar por Fecha";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(25, 114);
            button4.Name = "button4";
            button4.Size = new Size(101, 46);
            button4.TabIndex = 6;
            button4.Text = "Consultar por rango de Fecha";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(799, 118);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(145, 180);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Consultas de Factura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 64);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "Id_Factura";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(400, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(677, 67);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(744, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(799, 320);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(150, 202);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pago";
            // 
            // button5
            // 
            button5.Location = new Point(36, 150);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 13;
            button5.Text = "Pagar";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(26, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(25, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 15;
            textBox4.Text = "12%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 80);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 13;
            label7.Text = "Total a pagar";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 24);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 14;
            label8.Text = "IVA";
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(967, 545);
            Controls.Add(groupBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Facturacion";
            Text = "Facturacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnConsultar;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox4;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button5;
    }
}