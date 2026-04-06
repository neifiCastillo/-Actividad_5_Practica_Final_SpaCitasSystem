namespace SpaCitasSystem.WinForms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            serviciosToolStripMenuItem = new ToolStripMenuItem();
            terapeutasToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pnlTotal = new Panel();
            label1 = new Label();
            lblTotal = new Label();
            pnlVigente = new Panel();
            label3 = new Label();
            lblVigente = new Label();
            panel3 = new Panel();
            label4 = new Label();
            lblProceso = new Label();
            panel4 = new Panel();
            label5 = new Label();
            lblFinalizado = new Label();
            menuStrip1.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlVigente.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1168, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem, serviciosToolStripMenuItem, terapeutasToolStripMenuItem, citasToolStripMenuItem, salirToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(224, 26);
            pacientesToolStripMenuItem.Text = "Pacientes";
            pacientesToolStripMenuItem.Click += pacientesToolStripMenuItem_Click;
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            serviciosToolStripMenuItem.Size = new Size(224, 26);
            serviciosToolStripMenuItem.Text = "Servicios";
            serviciosToolStripMenuItem.Click += serviciosToolStripMenuItem_Click;
            // 
            // terapeutasToolStripMenuItem
            // 
            terapeutasToolStripMenuItem.Name = "terapeutasToolStripMenuItem";
            terapeutasToolStripMenuItem.Size = new Size(224, 26);
            terapeutasToolStripMenuItem.Text = "Terapeutas";
            terapeutasToolStripMenuItem.Click += terapeutasToolStripMenuItem_Click;
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(224, 26);
            citasToolStripMenuItem.Text = "Citas";
            citasToolStripMenuItem.Click += citasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.RoyalBlue;
            pnlTotal.Controls.Add(label1);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            pnlTotal.Location = new Point(43, 136);
            pnlTotal.Margin = new Padding(3, 4, 3, 4);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(273, 187);
            pnlTotal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(59, 43);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 6;
            label1.Text = "TOTAL CITAS";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = SystemColors.Control;
            lblTotal.Location = new Point(110, 125);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(99, 32);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "lblTotal";
            // 
            // pnlVigente
            // 
            pnlVigente.BackColor = Color.SeaGreen;
            pnlVigente.Controls.Add(label3);
            pnlVigente.Controls.Add(lblVigente);
            pnlVigente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            pnlVigente.Location = new Point(323, 136);
            pnlVigente.Margin = new Padding(3, 4, 3, 4);
            pnlVigente.Name = "pnlVigente";
            pnlVigente.Size = new Size(255, 187);
            pnlVigente.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(71, 43);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);
            label3.TabIndex = 8;
            label3.Text = "VIGENTES";
            // 
            // lblVigente
            // 
            lblVigente.AutoSize = true;
            lblVigente.ForeColor = SystemColors.Control;
            lblVigente.Location = new Point(98, 125);
            lblVigente.Name = "lblVigente";
            lblVigente.Size = new Size(131, 32);
            lblVigente.TabIndex = 7;
            lblVigente.Text = "lblVigente";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblProceso);
            panel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            panel3.Location = new Point(585, 136);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(264, 187);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(61, 43);
            label4.Name = "label4";
            label4.Size = new Size(161, 32);
            label4.TabIndex = 9;
            label4.Text = "EN PROCESO";
            // 
            // lblProceso
            // 
            lblProceso.AutoSize = true;
            lblProceso.ForeColor = SystemColors.Control;
            lblProceso.Location = new Point(112, 125);
            lblProceso.Name = "lblProceso";
            lblProceso.Size = new Size(134, 32);
            lblProceso.TabIndex = 8;
            lblProceso.Text = "lblProceso";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Brown;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblFinalizado);
            panel4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            panel4.Location = new Point(856, 136);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 187);
            panel4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(54, 43);
            label5.Name = "label5";
            label5.Size = new Size(170, 32);
            label5.TabIndex = 10;
            label5.Text = "FINALIZADAS";
            // 
            // lblFinalizado
            // 
            lblFinalizado.AutoSize = true;
            lblFinalizado.ForeColor = SystemColors.Control;
            lblFinalizado.Location = new Point(96, 125);
            lblFinalizado.Name = "lblFinalizado";
            lblFinalizado.Size = new Size(159, 32);
            lblFinalizado.TabIndex = 9;
            lblFinalizado.Text = "lblFinalizado";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.BACK;
            ClientSize = new Size(1168, 600);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pnlVigente);
            Controls.Add(pnlTotal);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += MainMenuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            pnlVigente.ResumeLayout(false);
            pnlVigente.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem serviciosToolStripMenuItem;
        private ToolStripMenuItem terapeutasToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Panel pnlTotal;
        private Panel pnlVigente;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label lblTotal;
        private Label label3;
        private Label lblVigente;
        private Label label4;
        private Label lblProceso;
        private Label label5;
        private Label lblFinalizado;
    }
}