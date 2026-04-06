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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitaForm));
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
            cbFiltroEstado = new ComboBox();
            dtFiltroFecha = new DateTimePicker();
            btnFiltrar = new Button();
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // cbPaciente
            // 
            cbPaciente.Cursor = Cursors.Hand;
            cbPaciente.Font = new Font("Segoe UI", 12F);
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new Point(7, 115);
            cbPaciente.Margin = new Padding(3, 4, 3, 4);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new Size(293, 36);
            cbPaciente.TabIndex = 5;
            // 
            // cbServicio
            // 
            cbServicio.Cursor = Cursors.Hand;
            cbServicio.Font = new Font("Segoe UI", 12F);
            cbServicio.FormattingEnabled = true;
            cbServicio.Location = new Point(7, 341);
            cbServicio.Margin = new Padding(3, 4, 3, 4);
            cbServicio.Name = "cbServicio";
            cbServicio.Size = new Size(292, 36);
            cbServicio.TabIndex = 9;
            // 
            // cbTerapeuta
            // 
            cbTerapeuta.Cursor = Cursors.Hand;
            cbTerapeuta.Font = new Font("Segoe UI", 12F);
            cbTerapeuta.FormattingEnabled = true;
            cbTerapeuta.Location = new Point(8, 227);
            cbTerapeuta.Margin = new Padding(3, 4, 3, 4);
            cbTerapeuta.Name = "cbTerapeuta";
            cbTerapeuta.Size = new Size(292, 36);
            cbTerapeuta.TabIndex = 7;
            // 
            // dtFecha
            // 
            dtFecha.Cursor = Cursors.Hand;
            dtFecha.Font = new Font("Segoe UI", 12F);
            dtFecha.Location = new Point(399, 220);
            dtFecha.Margin = new Padding(3, 4, 3, 4);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(345, 34);
            dtFecha.TabIndex = 8;
            // 
            // dtHora
            // 
            dtHora.Cursor = Cursors.Hand;
            dtHora.Font = new Font("Segoe UI", 12F);
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.Location = new Point(399, 111);
            dtHora.Margin = new Padding(3, 4, 3, 4);
            dtHora.Name = "dtHora";
            dtHora.ShowUpDown = true;
            dtHora.Size = new Size(345, 34);
            dtHora.TabIndex = 6;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(6, 573);
            dgvCitas.Margin = new Padding(3, 4, 3, 4);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new Size(1039, 285);
            dgvCitas.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(7, 45);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(215, 57);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(7, 171);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(215, 55);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.Green;
            btnExportCsv.Cursor = Cursors.Hand;
            btnExportCsv.ForeColor = SystemColors.ButtonFace;
            btnExportCsv.Location = new Point(7, 236);
            btnExportCsv.Margin = new Padding(3, 4, 3, 4);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(215, 55);
            btnExportCsv.TabIndex = 13;
            btnExportCsv.Text = "EXPORTAR CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.Firebrick;
            btnExportPdf.Cursor = Cursors.Hand;
            btnExportPdf.ForeColor = SystemColors.ButtonFace;
            btnExportPdf.Location = new Point(7, 299);
            btnExportPdf.Margin = new Padding(3, 4, 3, 4);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(215, 64);
            btnExportPdf.TabIndex = 14;
            btnExportPdf.Text = "EXPORTAR PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(7, 111);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(215, 52);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cbFiltroEstado
            // 
            cbFiltroEstado.Cursor = Cursors.Hand;
            cbFiltroEstado.FormattingEnabled = true;
            cbFiltroEstado.Location = new Point(15, 36);
            cbFiltroEstado.Margin = new Padding(3, 4, 3, 4);
            cbFiltroEstado.Name = "cbFiltroEstado";
            cbFiltroEstado.Size = new Size(231, 36);
            cbFiltroEstado.TabIndex = 1;
            // 
            // dtFiltroFecha
            // 
            dtFiltroFecha.Cursor = Cursors.Hand;
            dtFiltroFecha.Location = new Point(254, 36);
            dtFiltroFecha.Margin = new Padding(3, 4, 3, 4);
            dtFiltroFecha.Name = "dtFiltroFecha";
            dtFiltroFecha.ShowCheckBox = true;
            dtFiltroFecha.Size = new Size(348, 34);
            dtFiltroFecha.TabIndex = 12;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.Location = new Point(609, 36);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(128, 40);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "BUSCAR";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(cbFiltroEstado);
            groupBox1.Controls.Add(dtFiltroFecha);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(6, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1039, 92);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "FILTROS";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(744, 36);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 40);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dtHora);
            groupBox2.Controls.Add(cbPaciente);
            groupBox2.Controls.Add(cbServicio);
            groupBox2.Controls.Add(cbTerapeuta);
            groupBox2.Controls.Add(dtFecha);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(6, 116);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1039, 449);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "FORMULARIO DE CITAS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 183);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 16;
            label5.Text = "FECHA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 73);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 15;
            label4.Text = "HORA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 189);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 14;
            label3.Text = "TERAPEUTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 304);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 13;
            label2.Text = "SERVICIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 77);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 12;
            label1.Text = "PACIENTE";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Controls.Add(btnEditar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnExportPdf);
            groupBox3.Controls.Add(btnExportCsv);
            groupBox3.Location = new Point(805, 19);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(229, 412);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "OPCIONES";
            // 
            // CitaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 865);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvCitas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CitaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Citas";
            Load += CitaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
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
        private ComboBox cbFiltroEstado;
        private DateTimePicker dtFiltroFecha;
        private Button btnFiltrar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button btnLimpiar;
    }
}