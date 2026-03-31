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
            groupBox1 = new GroupBox();
            btnBorrar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtBuscar = new TextBox();
            btnLimpiar = new Button();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(11, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(268, 29);
            txtNombre.TabIndex = 0;
            // 
            // numDuracion
            // 
            numDuracion.Font = new Font("Segoe UI", 12F);
            numDuracion.Location = new Point(9, 169);
            numDuracion.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(270, 29);
            numDuracion.TabIndex = 1;
            // 
            // numPrecio
            // 
            numPrecio.Font = new Font("Segoe UI", 12F);
            numPrecio.Location = new Point(331, 85);
            numPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(215, 29);
            numPrecio.TabIndex = 2;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(12, 384);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(776, 196);
            dgvServicios.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(0, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(182, 38);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(0, 68);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(182, 34);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(0, 108);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(182, 35);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.Green;
            btnExportCsv.ForeColor = SystemColors.ButtonFace;
            btnExportCsv.Location = new Point(0, 147);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(182, 37);
            btnExportCsv.TabIndex = 7;
            btnExportCsv.Text = "EXPORTAR CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.Firebrick;
            btnExportPdf.ForeColor = SystemColors.ButtonFace;
            btnExportPdf.Location = new Point(0, 190);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(182, 38);
            btnExportPdf.TabIndex = 8;
            btnExportPdf.Text = "EXPORTAR PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numPrecio);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(numDuracion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 281);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "FORMULARIO DE SERVICIOS";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.Info;
            btnBorrar.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(234, -1);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(118, 26);
            btnBorrar.TabIndex = 21;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 60);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 20;
            label3.Text = "PRECIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 144);
            label2.Name = "label2";
            label2.Size = new Size(199, 21);
            label2.TabIndex = 19;
            label2.Text = "DURACION EN MINUTOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 60);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 18;
            label1.Text = "NOMBRE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnExportPdf);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnExportCsv);
            groupBox2.Location = new Point(586, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(182, 253);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPCIONES";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBuscar);
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btnFiltrar);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 79);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "FILTRO POR NOMBRE";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(11, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(341, 29);
            txtBuscar.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(476, 29);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 30);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(358, 29);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(112, 30);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "BUSCAR";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // ServicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 584);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgvServicios);
            Name = "ServicioForm";
            Text = "ServicioForm";
            Load += ServicioForm_Load;
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnLimpiar;
        private Button btnFiltrar;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBuscar;
        private Button btnBorrar;
    }
}