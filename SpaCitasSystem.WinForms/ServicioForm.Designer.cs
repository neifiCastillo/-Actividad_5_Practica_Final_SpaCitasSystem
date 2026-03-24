namespace SpaCitasSystem.WinForms
{
    partial class ServicioForm
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
            numDuracion = new NumericUpDown();
            numPrecio = new NumericUpDown();
            dgvServicios = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnExportCsv = new Button();
            btnExportPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 189);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(154, 190);
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(120, 23);
            numDuracion.TabIndex = 1;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(312, 190);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 2;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(28, 241);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(546, 150);
            dgvServicios.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(55, 58);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "btnAgregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(169, 58);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "btnEditar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(270, 58);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(387, 58);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(118, 23);
            btnExportCsv.TabIndex = 7;
            btnExportCsv.Text = "btnExportCsv";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(511, 58);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(143, 23);
            btnExportPdf.TabIndex = 8;
            btnExportPdf.Text = "btnExportPdf";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // ServicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportCsv);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvServicios);
            Controls.Add(numPrecio);
            Controls.Add(numDuracion);
            Controls.Add(txtNombre);
            Name = "ServicioForm";
            Text = "ServicioForm";
            Load += ServicioForm_Load;
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private NumericUpDown numDuracion;
        private NumericUpDown numPrecio;
        private DataGridView dgvServicios;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnExportCsv;
        private Button btnExportPdf;
    }
}