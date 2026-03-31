using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Shared.Export;
using SpaCitasSystem.Shared.Helpers;

namespace SpaCitasSystem.WinForms
{
    public partial class TerapeutaForm : Form
    {
        private readonly ITerapeutaService _service;

        public TerapeutaForm(ITerapeutaService service)
        {
            InitializeComponent();
            _service = service;
        }
        private async void TerapeutaForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            var data = (await _service.GetAllAsync())
                .OrderByDescending(t => t.Id)
                .ToList();

            dgvTerapeutas.DataSource = null;
            dgvTerapeutas.DataSource = data;

            DataGridViewHelper.ConfigurarGrid(dgvTerapeutas);

            dgvTerapeutas.CellClick += dgvTerapeutas_CellClick;
            dgvTerapeutas.ClearSelection();
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio");
                    return;
                }

                var dto = new TerapeutaDto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Especialidad = txtEspecialidad.Text.Trim()
                };

                await _service.AddAsync(dto);

                MessageBox.Show("Terapeuta agregado");

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
                if (dgvTerapeutas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un terapeuta");
                    return;
                }

                var dto = (TerapeutaDto)dgvTerapeutas.CurrentRow.DataBoundItem;

                dto.Nombre = txtNombre.Text.Trim();
                dto.Especialidad = txtEspecialidad.Text.Trim();

                await _service.UpdateAsync(dto);

                MessageBox.Show("Terapeuta actualizado");

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
                if (dgvTerapeutas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un terapeuta");
                    return;
                }

                var dto = (TerapeutaDto)dgvTerapeutas.CurrentRow.DataBoundItem;

                var confirm = MessageBox.Show(
                    "¿Seguro que deseas eliminar este terapeuta?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    await _service.DeleteAsync(dto.Id);

                    MessageBox.Show("Terapeuta eliminado");

                    await LoadData();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvTerapeutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTerapeutas.CurrentRow == null) return;

            var dto = (TerapeutaDto)dgvTerapeutas.CurrentRow.DataBoundItem;

            txtNombre.Text = dto.Nombre;
            txtEspecialidad.Text = dto.Especialidad;
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtEspecialidad.Clear();
            dgvTerapeutas.ClearSelection();
        }
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            ExportService.ExportToCsv(dgvTerapeutas);
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportService.ExportToPdf(dgvTerapeutas);
        }

        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            await LoadData();
        }
        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var data = (await _service.GetAllAsync()).ToList();

                var texto = txtBuscar.Text.Trim().ToLower();

                if (!string.IsNullOrEmpty(texto))
                {
                    data = data
                        .Where(t => t.Nombre.ToLower().Contains(texto))
                        .ToList();
                }

                if (!data.Any())
                {
                    MessageBox.Show("No se encontraron terapeutas");
                }

                dgvTerapeutas.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}