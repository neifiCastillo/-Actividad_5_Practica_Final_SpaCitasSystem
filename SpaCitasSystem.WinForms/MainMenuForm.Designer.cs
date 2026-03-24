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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            serviciosToolStripMenuItem = new ToolStripMenuItem();
            terapeutasToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem, serviciosToolStripMenuItem, terapeutasToolStripMenuItem, citasToolStripMenuItem, salirToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(180, 22);
            pacientesToolStripMenuItem.Text = "Pacientes";
            pacientesToolStripMenuItem.Click += pacientesToolStripMenuItem_Click;
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            serviciosToolStripMenuItem.Size = new Size(180, 22);
            serviciosToolStripMenuItem.Text = "Servicios";
            serviciosToolStripMenuItem.Click += serviciosToolStripMenuItem_Click;
            // 
            // terapeutasToolStripMenuItem
            // 
            terapeutasToolStripMenuItem.Name = "terapeutasToolStripMenuItem";
            terapeutasToolStripMenuItem.Size = new Size(180, 22);
            terapeutasToolStripMenuItem.Text = "Terapeutas";
            terapeutasToolStripMenuItem.Click += terapeutasToolStripMenuItem_Click;
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(180, 22);
            citasToolStripMenuItem.Text = "Citas";
            citasToolStripMenuItem.Click += citasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}