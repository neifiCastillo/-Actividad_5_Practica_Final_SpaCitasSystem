using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.DTOs;
using SpaCitasSystem.Shared.Export;
using SpaCitasSystem.Shared.Helpers;

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
            dgvCitas.CellFormatting += dgvCitas_CellFormatting;

            cbPaciente.DataSource = (await _pacienteService.GetAllAsync()).ToList();
            cbPaciente.DisplayMember = "Nombre";
            cbPaciente.ValueMember = "Id";

            cbServicio.DataSource = (await _servicioService.GetAllAsync()).ToList();
            cbServicio.DisplayMember = "Nombre";
            cbServicio.ValueMember = "Id";

            cbTerapeuta.DataSource = (await _terapeutaService.GetAllAsync()).ToList();
            cbTerapeuta.DisplayMember = "Nombre";
            cbTerapeuta.ValueMember = "Id";

            cbFiltroEstado.Items.Clear();
            cbFiltroEstado.Items.Add("Todos");
            cbFiltroEstado.Items.Add("Vigente");
            cbFiltroEstado.Items.Add("En proceso");
            cbFiltroEstado.Items.Add("Finalizado");
            cbFiltroEstado.SelectedIndex = 0;

            dtFecha.Format = DateTimePickerFormat.Custom;
            dtFecha.CustomFormat = "dd/MM/yyyy";

            await LoadData();
        }


        private async Task LoadData()
        {
            dgvCitas.DataSource = (await _citaService.GetAllAsync()).OrderByDescending(c => c.Fecha)
                                                                    .ThenByDescending(c => c.Hora)
                                                                    .ToList();

            dgvCitas.Columns["PacienteNombre"].HeaderText = "Paciente";
            dgvCitas.Columns["ServicioNombre"].HeaderText = "Servicio";
            dgvCitas.Columns["TerapeutaNombre"].HeaderText = "Terapeuta";
            dgvCitas.Columns["DuracionMinutos"].HeaderText = "Duración (min)";
            dgvCitas.Columns["DiasRestantes"].HeaderText = "Días restantes";

            DataGridViewHelper.ConfigurarGrid(dgvCitas);

            dgvCitas.Columns["PacienteId"].Visible = false;
            dgvCitas.Columns["ServicioId"].Visible = false;
            dgvCitas.Columns["TerapeutaId"].Visible = false;
            dgvCitas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dgvCitas.Columns["Hora"].DefaultCellStyle.Format = @"hh\:mm";

            dtFiltroFecha.Format = DateTimePickerFormat.Custom;
            dtFiltroFecha.CustomFormat = "dd/MM/yyyy";

            dgvCitas.CellClick += dgvCitas_CellClick;
            dgvCitas.ClearSelection();
        }
        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCitas.CurrentRow == null)
                return;

            var dto = (CitaDto)dgvCitas.CurrentRow.DataBoundItem;

            cbPaciente.SelectedValue = dto.PacienteId;
            cbServicio.SelectedValue = dto.ServicioId;
            cbTerapeuta.SelectedValue = dto.TerapeutaId;

            dtFecha.Value = dto.Fecha;
            dtHora.Value = DateTime.Today.Add(dto.Hora);

            bool editable = dto.Estado != "En proceso";

            btnEditar.Enabled = editable;
            btnEliminar.Enabled = editable;
        }

        private bool ValidarEstado(CitaDto dto)
        {
            if (dto.Estado == "En proceso")
            {
                MessageBox.Show("No se puede modificar una cita en proceso");
                return false;
            }

            return true;
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
                if (dgvCitas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una cita");
                    return;
                }

                if (!ValidarFormulario())
                    return;

                var dto = (CitaDto)dgvCitas.CurrentRow.DataBoundItem;

                if (!ValidarEstado(dto))
                    return;

                dto.PacienteId = (int)cbPaciente.SelectedValue!;
                dto.ServicioId = (int)cbServicio.SelectedValue!;
                dto.TerapeutaId = (int)cbTerapeuta.SelectedValue!;
                dto.Fecha = dtFecha.Value.Date;
                dto.Hora = dtHora.Value.TimeOfDay;

                await _citaService.UpdateAsync(dto);

                MessageBox.Show("Cita actualizada correctamente");

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
                if (dgvCitas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una cita");
                    return;
                }

                var dto = (CitaDto)dgvCitas.CurrentRow.DataBoundItem;

                if (!ValidarEstado(dto))
                    return;

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
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void dgvCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCitas.Columns[e.ColumnIndex].Name == "Estado")
            {
                var estado = e.Value?.ToString();

                if (estado == "Vigente")
                    dgvCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

                else if (estado == "En proceso")
                    dgvCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Khaki;

                else if (estado == "Finalizado")
                    dgvCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
            }

            if (dgvCitas.Columns[e.ColumnIndex].Name == "Hora" && e.Value != null)
            {
                if (TimeSpan.TryParse(e.Value.ToString(), out TimeSpan hora))
                {
                    var fechaHora = DateTime.Today.Add(hora);
                    e.Value = fechaHora.ToString("h:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }
        private void Limpiar()
        {
            cbPaciente.SelectedIndex = 0;
            cbServicio.SelectedIndex = 0;
            cbTerapeuta.SelectedIndex = 0;

            dtFecha.Value = DateTime.Now;
            dtHora.Value = DateTime.Now;
        }
        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var data = (await _citaService.GetAllAsync()).ToList();

                if (cbFiltroEstado.SelectedItem?.ToString() != "Todos")
                {
                    data = data
                        .Where(c => c.Estado == cbFiltroEstado.SelectedItem!.ToString())
                        .ToList();
                }
                if (dtFiltroFecha.Checked)
                {
                    data = data
                        .Where(c => c.Fecha.Date == dtFiltroFecha.Value.Date)
                        .ToList();
                }
                data = data.OrderBy(c => c.Fecha).ToList();
                if (!data.Any())
                {
                    MessageBox.Show("No hay citas para los filtros seleccionados");
                }

                dgvCitas.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            ExportService.ExportToCsv(dgvCitas);
        }
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportService.ExportToPdf(dgvCitas, "Reporte de Citas");
        }
        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbFiltroEstado.SelectedIndex = 0;
            dtFiltroFecha.Value = DateTime.Now;
            await LoadData();
        }
    }
}
