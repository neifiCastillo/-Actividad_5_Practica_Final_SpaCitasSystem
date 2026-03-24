using Microsoft.Extensions.DependencyInjection;

namespace SpaCitasSystem.WinForms
{
    public partial class MainMenuForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainMenuForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<PacienteForm>();
            form.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<ServicioForm>();
            form.Show();

        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<CitaForm>();
            form.Show();
        }

        private void terapeutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<TerapeutaForm>();
            form.Show();
        }
    }
}
