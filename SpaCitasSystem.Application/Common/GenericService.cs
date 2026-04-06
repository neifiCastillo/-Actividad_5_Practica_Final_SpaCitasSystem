using AutoMapper;
using SpaCitasSystem.Infrastructure.Interfaces;

namespace SpaCitasSystem.Application.Common
{
    public class GenericService<TEntity, TDto> : IGenericService<TDto>
        where TEntity : class
        where TDto : class
    {
        protected readonly IGenericRepository<TEntity> _repo;
        protected readonly IMapper _mapper;
        public GenericService(
            IGenericRepository<TEntity> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public virtual async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }
        public virtual async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await _repo.GetByIdAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public virtual async Task AddAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repo.AddAsync(entity);
        }
        public virtual async Task UpdateAsync(TDto dto)
        {
            var idProperty = typeof(TDto).GetProperty("Id");

            if (idProperty == null)
                throw new Exception("El DTO no tiene propiedad Id");

            var id = Convert.ToInt32(idProperty.GetValue(dto));
            var entity = await _repo.GetByIdAsync(id);

            if (entity == null)
                throw new Exception("Registro no encontrado");
            _mapper.Map(dto, entity);

            await _repo.UpdateAsync(entity);
        }
        public virtual async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }
    }
}