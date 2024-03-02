namespace GUI_PELUQUERIA
{
    partial class Parametros
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btMoneda = new Button();
            btIVA = new Button();
            txtMoneda = new TextBox();
            txtIVA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(608, 22);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 0;
            label1.Text = "Parametros";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btMoneda);
            groupBox1.Controls.Add(btIVA);
            groupBox1.Controls.Add(txtMoneda);
            groupBox1.Controls.Add(txtIVA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(491, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 133);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // btMoneda
            // 
            btMoneda.ForeColor = Color.Black;
            btMoneda.Location = new Point(449, 86);
            btMoneda.Name = "btMoneda";
            btMoneda.Size = new Size(83, 22);
            btMoneda.TabIndex = 5;
            btMoneda.Text = "Actualizar";
            btMoneda.UseVisualStyleBackColor = true;
            btMoneda.Click += btMoneda_Click;
            // 
            // btIVA
            // 
            btIVA.ForeColor = SystemColors.Desktop;
            btIVA.Location = new Point(449, 33);
            btIVA.Name = "btIVA";
            btIVA.Size = new Size(78, 25);
            btIVA.TabIndex = 4;
            btIVA.Text = "Actualizar";
            btIVA.UseVisualStyleBackColor = true;
            btIVA.Click += btIVA_Click;
            // 
            // txtMoneda
            // 
            txtMoneda.Location = new Point(130, 86);
            txtMoneda.Name = "txtMoneda";
            txtMoneda.Size = new Size(292, 23);
            txtMoneda.TabIndex = 3;
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(128, 35);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(295, 23);
            txtIVA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 96);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Moneda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 35);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 0;
            label2.Text = "IVA";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(508, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(375, 89);
            dataGridView1.TabIndex = 2;
            // 
            // Parametros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1100, 600);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Parametros";
            Text = "Parametros";
            Load += Parametros_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtIVA;
        private Label label3;
        private Label label2;
        private Button btMoneda;
        private Button btIVA;
        private TextBox txtMoneda;
        private DataGridView dataGridView1;
    }
}