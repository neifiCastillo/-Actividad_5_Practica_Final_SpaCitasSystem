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
            cbPaciente.Font = new Font("Segoe UI", 12F);
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new Point(6, 86);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new Size(257, 29);
            cbPaciente.TabIndex = 0;
            // 
            // cbServicio
            // 
            cbServicio.Font = new Font("Segoe UI", 12F);
            cbServicio.FormattingEnabled = true;
            cbServicio.Location = new Point(6, 256);
            cbServicio.Name = "cbServicio";
            cbServicio.Size = new Size(256, 29);
            cbServicio.TabIndex = 1;
            // 
            // cbTerapeuta
            // 
            cbTerapeuta.Font = new Font("Segoe UI", 12F);
            cbTerapeuta.FormattingEnabled = true;
            cbTerapeuta.Location = new Point(7, 170);
            cbTerapeuta.Name = "cbTerapeuta";
            cbTerapeuta.Size = new Size(256, 29);
            cbTerapeuta.TabIndex = 2;
            // 
            // dtFecha
            // 
            dtFecha.Font = new Font("Segoe UI", 12F);
            dtFecha.Location = new Point(349, 165);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(302, 29);
            dtFecha.TabIndex = 3;
            // 
            // dtHora
            // 
            dtHora.Font = new Font("Segoe UI", 12F);
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.Location = new Point(349, 83);
            dtHora.Name = "dtHora";
            dtHora.ShowUpDown = true;
            dtHora.Size = new Size(302, 29);
            dtHora.TabIndex = 4;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(5, 430);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(909, 214);
            dgvCitas.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(6, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(188, 43);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(6, 128);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 41);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.Green;
            btnExportCsv.ForeColor = SystemColors.ButtonFace;
            btnExportCsv.Location = new Point(6, 177);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(188, 41);
            btnExportCsv.TabIndex = 8;
            btnExportCsv.Text = "EXPORTAR CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.Firebrick;
            btnExportPdf.ForeColor = SystemColors.ButtonFace;
            btnExportPdf.Location = new Point(6, 224);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(188, 48);
            btnExportPdf.TabIndex = 9;
            btnExportPdf.Text = "EXPORTAR PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(6, 83);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(188, 39);
            btnEditar.TabIndex = 10;
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
            cbFiltroEstado.FormattingEnabled = true;
            cbFiltroEstado.Location = new Point(13, 27);
            cbFiltroEstado.Name = "cbFiltroEstado";
            cbFiltroEstado.Size = new Size(203, 29);
            cbFiltroEstado.TabIndex = 11;
            // 
            // dtFiltroFecha
            // 
            dtFiltroFecha.Location = new Point(222, 27);
            dtFiltroFecha.Name = "dtFiltroFecha";
            dtFiltroFecha.ShowCheckBox = true;
            dtFiltroFecha.Size = new Size(305, 29);
            dtFiltroFecha.TabIndex = 12;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(533, 27);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(112, 30);
            btnFiltrar.TabIndex = 13;
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
            groupBox1.Location = new Point(5, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 69);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "FILTROS";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(651, 27);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 30);
            btnLimpiar.TabIndex = 14;
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
            groupBox2.Location = new Point(5, 87);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(909, 337);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "FORMULARIO DE CITAS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 137);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 16;
            label5.Text = "FECHA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 55);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 15;
            label4.Text = "HORA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 142);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 14;
            label3.Text = "TERAPEUTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 228);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 13;
            label2.Text = "SERVICIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 58);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
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
            groupBox3.Location = new Point(704, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 309);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "OPCIONES";
            // 
            // CitaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 649);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvCitas);
            Name = "CitaForm";
            Text = "CitaForm";
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