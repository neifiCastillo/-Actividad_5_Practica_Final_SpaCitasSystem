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
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            dgvPacientes = new DataGridView();
            btnExportCsv = new Button();
            btnExportPdf = new Button();
            groupBox1 = new GroupBox();
            btnBorrar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            groupBox3 = new GroupBox();
            txtBuscar = new TextBox();
            btnLimpiar = new Button();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(8, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 29);
            txtEmail.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(8, 139);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(289, 29);
            txtTelefono.TabIndex = 5;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(8, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(289, 29);
            txtNombre.TabIndex = 4;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(10, 386);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(801, 168);
            dgvPacientes.TabIndex = 8;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.Green;
            btnExportCsv.ForeColor = SystemColors.ButtonFace;
            btnExportCsv.Location = new Point(0, 147);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(225, 33);
            btnExportCsv.TabIndex = 9;
            btnExportCsv.Text = "EXPORTAR CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.Firebrick;
            btnExportPdf.ForeColor = SystemColors.ButtonFace;
            btnExportPdf.Location = new Point(0, 186);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(225, 30);
            btnExportPdf.TabIndex = 10;
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
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 289);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "FORMULARIO DE PACIENTES";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.Info;
            btnBorrar.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(234, 0);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(118, 26);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 189);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 14;
            label3.Text = "EMAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 115);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 13;
            label2.Text = "TELEFONO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 12;
            label1.Text = "NOMBRE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnExportPdf);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnExportCsv);
            groupBox2.Location = new Point(567, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(225, 270);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPCIONES";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(0, 107);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 32);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(0, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(225, 33);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(0, 73);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(225, 28);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBuscar);
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btnFiltrar);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(10, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(801, 79);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "FILTRO POR NOMBRE";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(9, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(389, 29);
            txtBuscar.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(521, 29);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 30);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(404, 29);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(112, 30);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "BUSCAR";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // PacienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 566);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgvPacientes);
            Name = "PacienteForm";
            Text = "PacienteForm";
            Load += PacienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private DataGridView dgvPacientes;
        private Button btnExportCsv;
        private Button btnExportPdf;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnEditar;
        private GroupBox groupBox2;
        private Button btnAgregar;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnLimpiar;
        private Button btnFiltrar;
        private TextBox txtBuscar;
        private Button btnBorrar;
    }
}