using AutoMapper;
using CustomFormBuilder.Application.Contract.FormVersions;
using CustomFormBuilder.Application.Contract.FormVersions.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormVersions.Dtos.Response;
using CustomFormBuilder.Domain.FormVersions;

namespace CustomFormBuilder.Application.Services
{
    public class FormVersionService : IFormVersionService
    {
        private readonly IFormVersionManager _manager;
        private readonly IFormVersionRepository _repository;
        private readonly IMapper _mapper;

        public FormVersionService(
            IFormVersionManager manager,
            IFormVersionRepository repository,
            IMapper mapper)
        {
            _manager = manager;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> CreateAsync(CreateFormVersionRequest request)
        {
            var formVersion = await _manager.CreateAsync(request.Version, request.FormId);
            return formVersion.Id;
        }

        public async Task UpdateVersionAsync(UpdateFormVersionRequest request)
        {
            await _manager.UpdateVersionAsync(request.Id, request.Version);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _manager.DeleteAsync(id);
        }

        public async Task<FormVersionResponse> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetAsync(id);
            return _mapper.Map<FormVersionResponse>(entity);
        }

        public async Task<IEnumerable<FormVersionResponse>> GetAllAsync()
        {
            var list = await _repository.GetListAsync();
            return _mapper.Map<IEnumerable<FormVersionResponse>>(list);
        }

        public async Task<FormVersionResponse> GetByVersionAsync(string version)
        {
            var list = await _repository.GetListAsync(v => v.Version == version);
            return _mapper.Map<FormVersionResponse>(list.FirstOrDefault());
        }
    }
}
