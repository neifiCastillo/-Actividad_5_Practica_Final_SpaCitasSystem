using Microsoft.IdentityModel.Tokens;
using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Shared.Export;
using SpaCitasSystem.Shared.Helpers;

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

            await LoadData();

        }
        private async Task LoadData()
        {
            var data = (await _pacienteService.GetAllAsync()).OrderByDescending(c => c.Id).ToList();
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = data.ToList();
            DataGridViewHelper.ConfigurarGrid(dgvPacientes);
            dgvPacientes.CellClick += dgvPacientes_CellClick;
            dgvPacientes.ClearSelection();
            txtTelefono.TextChanged += txtTelefono_TextChanged;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            var cursor = txtTelefono.SelectionStart;

            InputValidatorHelper.FormatearTelefonoRD(txtTelefono);

            txtTelefono.SelectionStart = txtTelefono.Text.Length;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputValidator()) return;

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
                if (!InputValidator()) return;

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
        private bool InputValidator()
        {
            if (!InputValidatorHelper.EsTelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("Teléfono inválido. Formato: 809-000-0000");
                return false;
            }

            if (!InputValidatorHelper.EsEmailValido(txtEmail.Text))
            {
                MessageBox.Show("Correo electrónico inválido");
                return false;
            }

            return true;
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
        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var data = (await _pacienteService.GetAllAsync()).ToList();

                var texto = txtBuscar.Text.Trim().ToLower();

                if (!string.IsNullOrEmpty(texto))
                {
                    data = data
                        .Where(p => p.Nombre.ToLower().Contains(texto))
                        .ToList();
                }

                if (!data.Any())
                {
                    MessageBox.Show("No se encontraron pacientes");
                }

                dgvPacientes.DataSource = data;
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
        }
        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            await LoadData();
        }
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            ExportService.ExportToCsv(dgvPacientes);
        }
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportService.ExportToPdf(dgvPacientes);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
