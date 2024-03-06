namespace GUI_PELUQUERIA
{
    partial class Stock
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
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(712, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 27);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 3;
            label3.Text = "l";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(430, 172);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 23);
            textBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(430, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 75);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nombre Producto";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(367, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 199);
            dataGridView1.TabIndex = 9;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1020, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(49, 66, 82);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stock";
            Text = "Stock";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button button1;
        private DataGridView dataGridView1;
    }
}