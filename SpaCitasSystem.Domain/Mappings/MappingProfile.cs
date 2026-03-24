using AutoMapper;
using SpaCitasSystem.Domain.Entities;
using SpaCitasSystem.Domain.DTOs;

namespace SpaCitasSystem.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Paciente, PacienteDto>().ReverseMap();
            CreateMap<Servicio, ServicioDto>().ReverseMap();
            CreateMap<Cita, CitaDto>().ReverseMap();
            CreateMap<Terapeuta, TerapeutaDto>().ReverseMap();
        }
    }
}