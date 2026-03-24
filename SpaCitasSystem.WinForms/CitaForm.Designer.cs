namespace SpaCitasSystem.WinForms
{
    partial class CitaForm
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
            cbPaciente = new ComboBox();
            cbServicio = new ComboBox();
            cbTerapeuta = new ComboBox();
            dtFecha = new DateTimePicker();
            dtHora = new DateTimePicker();
            dgvCitas = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnExportCsv = new Button();
            btnExportPdf = new Button();
            btnEditar = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // cbPaciente
            // 
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new Point(21, 91);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new Size(121, 23);
            cbPaciente.TabIndex = 0;
            // 
            // cbServicio
            // 
            cbServicio.FormattingEnabled = true;
            cbServicio.Location = new Point(161, 91);
            cbServicio.Name = "cbServicio";
            cbServicio.Size = new Size(121, 23);
            cbServicio.TabIndex = 1;
            // 
            // cbTerapeuta
            // 
            cbTerapeuta.FormattingEnabled = true;
            cbTerapeuta.Location = new Point(303, 91);
            cbTerapeuta.Name = "cbTerapeuta";
            cbTerapeuta.Size = new Size(121, 23);
            cbTerapeuta.TabIndex = 2;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(42, 135);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 23);
            dtFecha.TabIndex = 3;
            // 
            // dtHora
            // 
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.Location = new Point(271, 135);
            dtHora.Name = "dtHora";
            dtHora.ShowUpDown = true;
            dtHora.Size = new Size(183, 23);
            dtHora.TabIndex = 4;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(49, 235);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(548, 150);
            dgvCitas.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(50, 191);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "btnAgregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(148, 191);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(254, 191);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(88, 23);
            btnExportCsv.TabIndex = 8;
            btnExportCsv.Text = "btnExportCsv";
            btnExportCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(365, 191);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(106, 23);
            btnExportPdf.TabIndex = 9;
            btnExportPdf.Text = "btnExportPdf";
            btnExportPdf.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(477, 191);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = " btnEditar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // CitaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportCsv);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCitas);
            Controls.Add(dtHora);
            Controls.Add(dtFecha);
            Controls.Add(cbTerapeuta);
            Controls.Add(cbServicio);
            Controls.Add(cbPaciente);
            Name = "CitaForm";
            Text = "CitaForm";
            Load += CitaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbPaciente;
        private ComboBox cbServicio;
        private ComboBox cbTerapeuta;
        private DateTimePicker dtFecha;
        private DateTimePicker dtHora;
        private DataGridView dgvCitas;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnExportCsv;
        private Button btnExportPdf;
        private Button btnEditar;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}