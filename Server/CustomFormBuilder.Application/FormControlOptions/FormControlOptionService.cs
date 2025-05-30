using AutoMapper;
using CustomFormBuilder.Application.Contract.FormControlOptions;
using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Response;
using CustomFormBuilder.Domain.FormControlOptions;


namespace CustomFormBuilder.Application.FormControlOptions
{
    public class FormControlOptionService : IFormControlOptionService
    {
        private readonly IFormControlOptionManager _manager;
        private readonly IFormControlOptionRepository _repository;
        private readonly IMapper _mapper;
        public FormControlOptionService(IFormControlOptionManager manager, IFormControlOptionRepository repository, IMapper mapper)
        {
            _manager = manager;
            _repository = repository;
            _mapper = mapper;   
        }

        public async Task<Guid> CreateAsync(CreateFormControlOptionRequest request)
        {
            var option = await _manager.CreateAsync(request.Value, request.DisplayText, request.FormControlId);
            return option.Id;
        }

        public async Task UpdateAsync(UpdateFormControlOptionRequest request)
        {
            await _manager.UpdateAsync(request.Id, request.Value, request.DisplayText);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _manager.DeleteAsync(id);
        }

        public async Task<FormControlOptionResponse> GetByIdAsync(Guid id) => _mapper.Map<FormControlOptionResponse>(await _repository.GetAsync(id));
        public async Task<IEnumerable<FormControlOptionResponse>> GetAllAsync() => _mapper.Map <IEnumerable<FormControlOptionResponse>>(await _repository.GetListAsync());
        public async Task<FormControlOptionResponse> GetByValueAsync(string value) =>
            _mapper.Map<FormControlOptionResponse>((await _repository.GetListAsync(o => o.Value == value)).FirstOrDefault());
    }

}
