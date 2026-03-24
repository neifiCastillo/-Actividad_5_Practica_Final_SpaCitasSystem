namespace SpaCitasSystem.WinForms
{
    partial class PacienteForm
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
            txtEmail = new TextBox();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            dgvPacientes = new DataGridView();
            btnExportCsv = new Button();
            btnExportPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(348, 38);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(38, 103);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(172, 38);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(38, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(1, 224);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(738, 150);
            dgvPacientes.TabIndex = 8;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(197, 103);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(75, 23);
            btnExportCsv.TabIndex = 9;
            btnExportCsv.Text = "ExportCsv";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(362, 90);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(75, 23);
            btnExportPdf.TabIndex = 10;
            btnExportPdf.Text = "ExportPdf";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // PacienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportCsv);
            Controls.Add(dgvPacientes);
            Controls.Add(txtEmail);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "PacienteForm";
            Text = "PacienteForm";
            Load += PacienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private DataGridView dgvPacientes;
        private Button btnExportCsv;
        private Button btnExportPdf;
    }
}