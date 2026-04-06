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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerapeutaForm));
            txtNombre = new TextBox();
            txtEspecialidad = new TextBox();
            dgvTerapeutas = new DataGridView();
            groupBox3 = new GroupBox();
            txtBuscar = new TextBox();
            btnLimpiar = new Button();
            btnFiltrar = new Button();
            groupBox1 = new GroupBox();
            btnBorrar = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnExportPdf = new Button();
            btnEliminar = new Button();
            btnExportCsv = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTerapeutas).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(15, 112);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(346, 34);
            txtNombre.TabIndex = 5;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEspecialidad.Location = new Point(15, 225);
            txtEspecialidad.Margin = new Padding(3, 4, 3, 4);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(346, 34);
            txtEspecialidad.TabIndex = 6;
            // 
            // dgvTerapeutas
            // 
            dgvTerapeutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerapeutas.Location = new Point(14, 504);
            dgvTerapeutas.Margin = new Padding(3, 4, 3, 4);
            dgvTerapeutas.Name = "dgvTerapeutas";
            dgvTerapeutas.RowHeadersWidth = 51;
            dgvTerapeutas.Size = new Size(887, 275);
            dgvTerapeutas.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBuscar);
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btnFiltrar);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(14, 16);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(887, 105);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "FILTRO POR NOMBRE";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(15, 39);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(375, 34);
            txtBuscar.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(533, 37);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 40);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.Location = new Point(398, 37);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(128, 40);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "BUSCAR";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 129);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(887, 367);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "FORMULARIO DE TERAPEUTAS";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.Info;
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(287, 0);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(135, 35);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 192);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 19;
            label2.Text = "ESPECIALIDAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 80);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
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
            groupBox2.Location = new Point(671, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(208, 337);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPCIONES";
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(0, 32);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(208, 51);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(0, 91);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(208, 45);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.Firebrick;
            btnExportPdf.Cursor = Cursors.Hand;
            btnExportPdf.ForeColor = SystemColors.ButtonFace;
            btnExportPdf.Location = new Point(0, 253);
            btnExportPdf.Margin = new Padding(3, 4, 3, 4);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(208, 51);
            btnExportPdf.TabIndex = 11;
            btnExportPdf.Text = "EXPORTAR PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(0, 144);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(208, 47);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.Green;
            btnExportCsv.Cursor = Cursors.Hand;
            btnExportCsv.ForeColor = SystemColors.ButtonFace;
            btnExportCsv.Location = new Point(0, 196);
            btnExportCsv.Margin = new Padding(3, 4, 3, 4);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(208, 49);
            btnExportCsv.TabIndex = 10;
            btnExportCsv.Text = "EXPORTAR CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // TerapeutaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 783);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgvTerapeutas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TerapeutaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terapeutas";
            Load += TerapeutaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTerapeutas).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEspecialidad;
        private DataGridView dgvTerapeutas;
        private GroupBox groupBox3;
        private Button btnLimpiar;
        private Button btnFiltrar;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnExportPdf;
        private Button btnEliminar;
        private Button btnExportCsv;
        private TextBox txtBuscar;
        private Button btnBorrar;
    }
}