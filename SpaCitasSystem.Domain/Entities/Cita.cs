namespace SpaCitasSystem.Domain.Entities
{
    public class Cita
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }  

        public int ServicioId { get; set; }
        public Servicio? Servicio { get; set; } 

        public int TerapeutaId { get; set; }
        public Terapeuta? Terapeuta { get; set; } 

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }
    }
}
