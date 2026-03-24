using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Shared.Export;

namespace SpaCitasSystem.WinForms
{
    public partial class CitaForm : Form
    {
        private readonly ICitaService _citaService;
        private readonly IPacienteService _pacienteService;
        private readonly IServicioService _servicioService;
        private readonly ITerapeutaService _terapeutaService;

        public CitaForm(
            ICitaService citaService,
            IPacienteService pacienteService,
            IServicioService servicioService,
            ITerapeutaService terapeutaService)
        {
            InitializeComponent();

            _citaService = citaService;
            _pacienteService = pacienteService;
            _servicioService = servicioService;
            _terapeutaService = terapeutaService;
        }
        private async void CitaForm_Load(object sender, EventArgs e)
        {
            cbPaciente.DataSource = (await _pacienteService.GetAllAsync()).ToList();
            cbPaciente.DisplayMember = "Nombre";
            cbPaciente.ValueMember = "Id";

            cbServicio.DataSource = (await _servicioService.GetAllAsync()).ToList();
            cbServicio.DisplayMember = "Nombre";
            cbServicio.ValueMember = "Id";

            cbTerapeuta.DataSource = (await _terapeutaService.GetAllAsync()).ToList();
            cbTerapeuta.DisplayMember = "Nombre";
            cbTerapeuta.ValueMember = "Id";

            await LoadData();
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                    return;

                var dto = new CitaDto
                {
                    PacienteId = (int)cbPaciente.SelectedValue!,
                    ServicioId = (int)cbServicio.SelectedValue!,
                    TerapeutaId = (int)cbTerapeuta.SelectedValue!,
                    Fecha = dtFecha.Value.Date,
                    Hora = dtHora.Value.TimeOfDay
                };

                await _citaService.AddAsync(dto);

                MessageBox.Show("Cita creada");
                await LoadData();
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
                if (dgvCitas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una cita");
                    return;
                }

                if (!ValidarFormulario())
                    return;


                var dto = (CitaDto)dgvCitas.CurrentRow.DataBoundItem;

                dto.PacienteId = (int)cbPaciente.SelectedValue!;
                dto.ServicioId = (int)cbServicio.SelectedValue!;
                dto.TerapeutaId = (int)cbTerapeuta.SelectedValue!;
                dto.Fecha = dtFecha.Value.Date;
                dto.Hora = dtHora.Value.TimeOfDay;

                await _citaService.UpdateAsync(dto);

                MessageBox.Show("Cita actualizada correctamente");

                await LoadData();
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
                if (dgvCitas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una cita");
                    return;
                }

                var dto = (CitaDto)dgvCitas.CurrentRow.DataBoundItem;

                var confirm = MessageBox.Show(
                    "¿Seguro que deseas eliminar esta cita?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

                await _citaService.DeleteAsync(dto.Id);

                MessageBox.Show("Cita eliminada correctamente");

                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task LoadData()
        {
            dgvCitas.DataSource = (await _citaService.GetAllAsync()).ToList();
            //dgvCitas.ClearSelection();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            ExportService.ExportToCsv(dgvCitas);
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportService.ExportToPdf(dgvCitas);
        }
        private bool ValidarFormulario()
        {
            if (cbPaciente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un paciente");
                return false;
            }

            if (cbServicio.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un servicio");
                return false;
            }

            if (cbTerapeuta.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un terapeuta");
                return false;
            }

            return true;
        }
    }
}
