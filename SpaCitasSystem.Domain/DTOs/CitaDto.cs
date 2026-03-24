namespace SpaCitasSystem.Domain.DTOs
{
    public class CitaDto
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public string PacienteNombre { get; set; } = string.Empty;
        public int ServicioId { get; set; }
        public string ServicioNombre { get; set; } = string.Empty;
        public int TerapeutaId { get; set; }
        public string TerapeutaNombre { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int DuracionMinutos { get; set; }
        public int DiasRestantes { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
}
