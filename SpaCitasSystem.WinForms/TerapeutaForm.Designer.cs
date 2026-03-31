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
            txtNombre.Location = new Point(13, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(303, 29);
            txtNombre.TabIndex = 0;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEspecialidad.Location = new Point(13, 169);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(303, 29);
            txtEspecialidad.TabIndex = 1;
            // 
            // dgvTerapeutas
            // 
            dgvTerapeutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerapeutas.Location = new Point(12, 378);
            dgvTerapeutas.Name = "dgvTerapeutas";
            dgvTerapeutas.Size = new Size(776, 206);
            dgvTerapeutas.TabIndex = 2;
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
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "FILTRO POR NOMBRE";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(13, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(329, 29);
            txtBuscar.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(466, 28);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 30);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(348, 28);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(112, 30);
            btnFiltrar.TabIndex = 13;
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
            groupBox1.Location = new Point(12, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 275);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "FORMULARIO DE TERAPEUTAS";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.Info;
            btnBorrar.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(251, 0);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(118, 26);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 144);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 19;
            label2.Text = "ESPECIALIDAD";
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
            groupBox2.Location = new Point(587, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(182, 253);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPCIONES";
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
            // TerapeutaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 587);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgvTerapeutas);
            Name = "TerapeutaForm";
            Text = "TerapeutaForm";
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