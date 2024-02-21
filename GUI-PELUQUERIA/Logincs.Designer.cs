namespace GUI_PELUQUERIA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            lblLogin = new Label();
            button1 = new Button();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(15, 15, 15);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(302, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 16);
            textBox1.TabIndex = 1;
            textBox1.Text = "USUARIO";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(15, 15, 15);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.ForeColor = Color.DimGray;
            textBox2.Location = new Point(302, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 16);
            textBox2.TabIndex = 2;
            textBox2.Text = "CONTRASEÑA";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(302, 108);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(433, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(302, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(433, 23);
            txtPassword.TabIndex = 4;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.DimGray;
            lblLogin.Location = new Point(480, 37);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(87, 32);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "LOGIN";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(315, 252);
            button1.Name = "button1";
            button1.Size = new Size(408, 40);
            button1.TabIndex = 6;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = Color.DimGray;
            btnMinimizar.Location = new Point(714, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(34, 39);
            btnMinimizar.TabIndex = 7;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.DimGray;
            btnCerrar.Location = new Point(745, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 39);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "x";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(button1);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label lblLogin;
        private Button button1;
        private Button btnMinimizar;
        private Button btnCerrar;
        private PictureBox pictureBox1;
    }
}