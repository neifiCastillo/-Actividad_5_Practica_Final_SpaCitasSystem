using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SpaCitasSystem.Application.Interfaces;
using SpaCitasSystem.Application.Mappings;
using SpaCitasSystem.Application.Services;
using SpaCitasSystem.Infrastructure.Interfaces;
using SpaCitasSystem.Infrastructure.Repositories;

namespace SpaCitasSystem.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();

            var loginForm = host.Services.GetRequiredService<LoginForm>();
            System.Windows.Forms.Application.Run(loginForm);
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false);
                })
                .ConfigureServices((context, services) =>
                {
                    var configuration = context.Configuration;

                    // DbContext
                    services.AddDbContext<SpaDbContext>(options =>
                        options.UseSqlServer(
                            configuration.GetConnectionString("DefaultConnection")));

                    // Repositorios
                    services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

                    // Servicios
                    services.AddScoped<IAuthService, AuthService>();
                    services.AddScoped<IUsuarioService, UsuarioService>();
                    services.AddScoped<IPacienteService, PacienteService>();
                    services.AddScoped<IServicioService, ServicioService>();
                    services.AddScoped<ICitaService, CitaService>();
                    services.AddScoped<ITerapeutaService, TerapeutaService>();

                    //AutoMapper
                    services.AddAutoMapper(typeof(MappingProfile).Assembly);

                    // Formularios
                    services.AddTransient<LoginForm>();
                    services.AddTransient<RegisterForm>();
                    services.AddTransient<MainMenuForm>();
                    services.AddTransient<PacienteForm>();
                    services.AddTransient<ServicioForm>();
                    services.AddTransient<CitaForm>();
                    services.AddTransient<TerapeutaForm>();
                });
        }
    }
}