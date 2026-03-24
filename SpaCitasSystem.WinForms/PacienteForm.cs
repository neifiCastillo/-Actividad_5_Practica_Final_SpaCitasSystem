using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Shared.Export;

namespace SpaCitasSystem.WinForms
{
    public partial class PacienteForm : Form
    {
        private readonly IPacienteService _pacienteService;

        public PacienteForm(IPacienteService pacienteService)
        {
            InitializeComponent();
            _pacienteService = pacienteService;
        }
        private async void PacienteForm_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            await LoadData();
        }
        private async Task LoadData()
        {
            var data = await _pacienteService.GetAllAsync();

            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = data.ToList();
            dgvPacientes.ClearSelection();
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new PacienteDto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                await _pacienteService.AddAsync(dto);

                MessageBox.Show("Paciente agregado correctamente");

                await LoadData();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un paciente");
                    return;
                }

                var dto = (PacienteDto)dgvPacientes.CurrentRow.DataBoundItem;

                dto.Nombre = txtNombre.Text.Trim();
                dto.Telefono = txtTelefono.Text.Trim();
                dto.Email = txtEmail.Text.Trim();

                await _pacienteService.UpdateAsync(dto);

                MessageBox.Show("Paciente actualizado");

                await LoadData();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un paciente");
                    return;
                }

                var dto = (PacienteDto)dgvPacientes.CurrentRow.DataBoundItem;

                var confirm = MessageBox.Show(
                    "¿Seguro que deseas eliminar este paciente?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    await _pacienteService.DeleteAsync(dto.Id);

                    MessageBox.Show("Paciente eliminado");

                    await LoadData();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPacientes.CurrentRow == null) return;

            var dto = (PacienteDto)dgvPacientes.CurrentRow.DataBoundItem;

            txtNombre.Text = dto.Nombre;
            txtTelefono.Text = dto.Telefono;
            txtEmail.Text = dto.Email;
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            dgvPacientes.ClearSelection();
        }
        private void ConfigurarGrid()
        {
            dgvPacientes.ReadOnly = true;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.MultiSelect = false;
        }
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            ExportService.ExportToCsv(dgvPacientes);
        }
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportService.ExportToPdf(dgvPacientes);
        }
    }
}
