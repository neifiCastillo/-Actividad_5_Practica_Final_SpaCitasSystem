using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Domain.Entities;

namespace SpaCitasSystem.WinForms
{
    public partial class RegisterForm : Form
    {
        private readonly IUsuarioService _usuarioService;
        public RegisterForm(IUsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario
                {
                    Nombre = txtNombre.Text,
                    Username = txtUsername.Text,
                    PasswordHash = txtPassword.Text,
                    Activo = true
                };

                await _usuarioService.CrearUsuarioAsync(usuario);

                MessageBox.Show("Usuario creado correctamente");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
