using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Shared.Export;

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
            dgvTerapeutas.DataSource = (await _service.GetAllAsync()).ToList();
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new TerapeutaDto
                {
                    Nombre = txtNombre.Text,
                    Especialidad = txtEspecialidad.Text
                };

                await _service.AddAsync(dto);

                MessageBox.Show("Terapeuta agregado");
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var dto = (TerapeutaDto)dgvTerapeutas.CurrentRow.DataBoundItem;

            dto.Nombre = txtNombre.Text;
            dto.Especialidad = txtEspecialidad.Text;

            await _service.UpdateAsync(dto);

            MessageBox.Show("Actualizado");
            await LoadData();
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var dto = (TerapeutaDto)dgvTerapeutas.CurrentRow.DataBoundItem;

            await _service.DeleteAsync(dto.Id);

            MessageBox.Show("Eliminado");
            await LoadData();
        }
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            ExportService.ExportToCsv(dgvTerapeutas);
        }
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportService.ExportToPdf(dgvTerapeutas);
        }
    }
}
