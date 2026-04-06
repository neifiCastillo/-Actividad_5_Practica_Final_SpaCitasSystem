namespace SpaCitasSystem.WinForms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            txtNombre = new TextBox();
            txtUsername = new TextBox();
            btnGuardar = new Button();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(12, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 29);
            txtNombre.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = SystemColors.WindowFrame;
            txtUsername.Location = new Point(12, 220);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 29);
            txtUsername.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Teal;
            btnGuardar.Location = new Point(132, 380);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 57);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "REGISTRAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(12, 304);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 29);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 4;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 196);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 5;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 280);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 6;
            label3.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(12, 24);
            label4.Name = "label4";
            label4.Size = new Size(219, 21);
            label4.TabIndex = 7;
            label4.Text = "REGISTAR NUEVO USUARIO";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(450, 469);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(btnGuardar);
            Controls.Add(txtUsername);
            Controls.Add(txtNombre);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtUsername;
        private Button btnGuardar;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}