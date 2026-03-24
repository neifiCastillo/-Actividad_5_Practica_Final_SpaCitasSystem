namespace SpaCitasSystem.WinForms
{
    partial class TerapeutaForm
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
            txtNombre = new TextBox();
            txtEspecialidad = new TextBox();
            dgvTerapeutas = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnExportCsv = new Button();
            btnExportPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTerapeutas).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(76, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(205, 149);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(100, 23);
            txtEspecialidad.TabIndex = 1;
            // 
            // dgvTerapeutas
            // 
            dgvTerapeutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerapeutas.Location = new Point(17, 219);
            dgvTerapeutas.Name = "dgvTerapeutas";
            dgvTerapeutas.Size = new Size(729, 150);
            dgvTerapeutas.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(51, 62);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "btnAgregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(148, 62);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "btnEditar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(258, 62);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(372, 62);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(75, 23);
            btnExportCsv.TabIndex = 6;
            btnExportCsv.Text = "btnExportCsv";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(481, 62);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(75, 23);
            btnExportPdf.TabIndex = 7;
            btnExportPdf.Text = "btnExportPdf";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // TerapeutaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportCsv);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvTerapeutas);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtNombre);
            Name = "TerapeutaForm";
            Text = "TerapeutaForm";
            Load += TerapeutaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTerapeutas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEspecialidad;
        private DataGridView dgvTerapeutas;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnExportCsv;
        private Button btnExportPdf;
    }
}