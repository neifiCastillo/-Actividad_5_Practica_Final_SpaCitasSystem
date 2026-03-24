using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Shared.Export;

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
            dgvServicios.DataSource = (await _service.GetAllAsync()).ToList();
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new ServicioDto
                {
                    Nombre = txtNombre.Text,
                    DuracionMinutos = (int)numDuracion.Value,
                    Precio = numPrecio.Value
                };

                await _service.AddAsync(dto);

                MessageBox.Show("Servicio agregado");
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var dto = (ServicioDto)dgvServicios.CurrentRow.DataBoundItem;

            dto.Nombre = txtNombre.Text;
            dto.DuracionMinutos = (int)numDuracion.Value;
            dto.Precio = numPrecio.Value;

            await _service.UpdateAsync(dto);

            MessageBox.Show("Actualizado");
            await LoadData();
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var dto = (ServicioDto)dgvServicios.CurrentRow.DataBoundItem;

            await _service.DeleteAsync(dto.Id);

            MessageBox.Show("Eliminado");
            await LoadData();
        }
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            ExportService.ExportToCsv(dgvServicios);
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportService.ExportToPdf(dgvServicios);
        }
    }
}
