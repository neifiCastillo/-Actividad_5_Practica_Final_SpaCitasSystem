using Microsoft.Extensions.DependencyInjection;
using SpaCitasSystem.Application.Interfaces;

namespace SpaCitasSystem.WinForms
{
    public partial class MainMenuForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ICitaService _citaService;
        private PacienteForm? _pacienteForm;
        private ServicioForm? _servicioForm;
        private CitaForm? _citaForm;
        private TerapeutaForm? _terapeutaForm;
        public MainMenuForm(IServiceProvider serviceProvider, ICitaService citaService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _citaService = citaService;
        }
        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_pacienteForm == null || _pacienteForm.IsDisposed)
            {
                _pacienteForm = _serviceProvider.GetRequiredService<PacienteForm>();

                _pacienteForm.FormClosed += async (s, e) =>
                {
                    _pacienteForm = null;
                    await LoadDashboard();
                };

                _pacienteForm.Show();
            }
            else
            {
                _pacienteForm.WindowState = FormWindowState.Normal; 
                _pacienteForm.BringToFront();
                _pacienteForm.Activate(); 
            }
        }
        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_servicioForm == null || _servicioForm.IsDisposed)
            {
                _servicioForm = _serviceProvider.GetRequiredService<ServicioForm>();

                _servicioForm.FormClosed += async (s, e) =>
                {
                    _servicioForm = null;
                    await LoadDashboard();
                };

                _servicioForm.Show();
            }
            else
            {
                _servicioForm.WindowState = FormWindowState.Normal; 
                _servicioForm.BringToFront();
                _servicioForm.Activate(); 
            }
        }
        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_citaForm == null || _citaForm.IsDisposed)
            {
                _citaForm = _serviceProvider.GetRequiredService<CitaForm>();

                _citaForm.FormClosed += async (s, e) =>
                {
                    _citaForm = null;
                    await LoadDashboard();
                };

                _citaForm.Show();
            }
            else
            {
                _citaForm.WindowState = FormWindowState.Normal; 
                _citaForm.BringToFront();
                _citaForm.Activate(); 
            }
        }
        private void terapeutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_terapeutaForm == null || _terapeutaForm.IsDisposed)
            {
                _terapeutaForm = _serviceProvider.GetRequiredService<TerapeutaForm>();

                _terapeutaForm.FormClosed += async (s, e) =>
                {
                    _terapeutaForm = null;
                    await LoadDashboard();
                };

                _terapeutaForm.Show();
            }
            else
            {
                _terapeutaForm.WindowState = FormWindowState.Normal; 
                _terapeutaForm.BringToFront();
                _terapeutaForm.Activate(); 
            }
        }
        private async void MainMenuForm_Load(object sender, EventArgs e)
        {
            await LoadDashboard();
        }
        private async Task LoadDashboard()
        {
            var citas = (await _citaService.GetAllAsync()).ToList();

            var total = citas.Count;
            var vigentes = citas.Count(c => c.Estado == "Vigente");
            var proceso = citas.Count(c => c.Estado == "En proceso");
            var finalizadas = citas.Count(c => c.Estado == "Finalizado");

            lblTotal.Text = total.ToString();
            lblVigente.Text = vigentes.ToString();
            lblProceso.Text = proceso.ToString();
            lblFinalizado.Text = finalizadas.ToString();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas salir de la aplicación?","Confirmar salida",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }

        }
    }
}
