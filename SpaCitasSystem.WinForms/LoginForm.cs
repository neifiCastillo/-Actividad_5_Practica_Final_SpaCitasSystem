using Microsoft.Extensions.DependencyInjection;
using SpaCitasSystem.Application.Interfaces;

namespace SpaCitasSystem.WinForms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(IAuthService authService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _authService = authService;
            _serviceProvider = serviceProvider;
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var success = await _authService.LoginAsync(
                    txtUsername.Text,
                    txtPassword.Text);

                if (success)
                {
                    MessageBox.Show("Login exitoso");
                    var menu = _serviceProvider.GetRequiredService<MainMenuForm>();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = _serviceProvider.GetRequiredService<RegisterForm>();
            registerForm.ShowDialog();
        }
    }
}
