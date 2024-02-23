namespace GUI_PELUQUERIA
{
    partial class Agenda
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ListaCitas = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(596, 18);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 1;
            label1.Text = "Agenda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(291, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "N° Cita:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(291, 105);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "C.I. Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(291, 133);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 4;
            label4.Text = "Tipo Servicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(290, 165);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "Horario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(393, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(393, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(305, 23);
            textBox5.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Corte", "Tinturado", "Peinado" });
            comboBox1.Location = new Point(393, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(305, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Corte";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "9:30-10:30  ", "10:30-11:30 ", "11:30-12:30 ", "14:00-15:00", "15:00-17:00", "17:00-19:00", "19:00-21:00", "   " });
            comboBox2.Location = new Point(393, 165);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(305, 23);
            comboBox2.TabIndex = 13;
            // 
            // ListaCitas
            // 
            ListaCitas.FormattingEnabled = true;
            ListaCitas.ItemHeight = 15;
            ListaCitas.Location = new Point(290, 266);
            ListaCitas.Name = "ListaCitas";
            ListaCitas.Size = new Size(705, 109);
            ListaCitas.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(470, 211);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(613, 211);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 19;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(338, 211);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 20;
            button4.Text = "Registrar";
            button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(781, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(734, 72);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 22;
            label6.Text = "Fecha:";
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1063, 472);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ListaCitas);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agenda";
            Text = "Agenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ListBox ListaCitas;
        private Button button2;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}