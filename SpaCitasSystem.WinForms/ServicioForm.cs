using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Shared.Export;
using SpaCitasSystem.Shared.Helpers;

namespace SpaCitasSystem.WinForms
{
    public partial class ServicioForm : Form
    {
        private readonly IServicioService _service;
        public ServicioForm(IServicioService service)
        {
            InitializeComponent();
            _service = service;
        }
        private async void ServicioForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            var data = (await _service.GetAllAsync())
                .OrderByDescending(s => s.Id)
                .ToList();

            dgvServicios.DataSource = null;
            dgvServicios.DataSource = data;

            DataGridViewHelper.ConfigurarGrid(dgvServicios);
            dgvServicios.Columns["DuracionMinutos"].HeaderText = "Duración (min)";

            dgvServicios.CellClick += dgvServicios_CellClick;
            dgvServicios.ClearSelection();
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

                var dto = new ServicioDto
                {
                    Nombre = txtNombre.Text.Trim(),
                    DuracionMinutos = (int)numDuracion.Value,
                    Precio = numPrecio.Value
                };

                await _service.AddAsync(dto);

                MessageBox.Show("Servicio agregado");

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
                if (dgvServicios.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un servicio");
                    return;
                }

                var dto = (ServicioDto)dgvServicios.CurrentRow.DataBoundItem;

                dto.Nombre = txtNombre.Text.Trim();
                dto.DuracionMinutos = (int)numDuracion.Value;
                dto.Precio = numPrecio.Value;

                await _service.UpdateAsync(dto);

                MessageBox.Show("Servicio actualizado");

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
                if (dgvServicios.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un servicio");
                    return;
                }

                var dto = (ServicioDto)dgvServicios.CurrentRow.DataBoundItem;

                var confirm = MessageBox.Show(
                    "¿Seguro que deseas eliminar este servicio?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    await _service.DeleteAsync(dto.Id);

                    MessageBox.Show("Servicio eliminado");

                    await LoadData();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvServicios_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvServicios.CurrentRow == null) return;

            var dto = (ServicioDto)dgvServicios.CurrentRow.DataBoundItem;

            txtNombre.Text = dto.Nombre;
            numDuracion.Value = dto.DuracionMinutos;
            numPrecio.Value = dto.Precio;
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            numDuracion.Value = 0;
            numPrecio.Value = 0;

            dgvServicios.ClearSelection();
        }
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            ExportService.ExportToCsv(dgvServicios);
        }
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportService.ExportToPdf(dgvServicios, "Reporte de Servicios");
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
                        .Where(p => p.Nombre.ToLower().Contains(texto))
                        .ToList();
                }

                if (!data.Any())
                {
                    MessageBox.Show("No se encontraron pacientes");
                }

                dgvServicios.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}