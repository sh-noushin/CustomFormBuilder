using AutoMapper;
using CustomFormBuilder.Application.Contract.FormControlOptions;
using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Response;
using CustomFormBuilder.Application.Contract.FormControlValues.Dtos.Request;
using CustomFormBuilder.Domain.FormControlValues;


namespace CustomFormBuilder.Application.FormControlOptions
{
    public class FormControlValueService : IFormControlValueService
    {
        private readonly IFormControlValueManager _manager;
        private readonly IFormControlValueRepository _repository;
        private readonly IMapper _mapper;
        public FormControlValueService(IFormControlValueManager manager, IFormControlValueRepository repository, IMapper mapper)
        {
            _manager = manager;
            _repository = repository;
            _mapper = mapper;   
        }

        public async Task<Guid> CreateAsync(CreateFormControlValueRequest request)
        {
            var option = await _manager.CreateAsync(request.Value, request.FormControlId);
            return option.Id;
        }

        public async Task UpdateAsync(UpdateFormControlValueRequest request)
        {
            await _manager.UpdateAsync(request.Id, request.Value);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _manager.DeleteAsync(id);
        }

        public async Task<FormControlValueResponse> GetByIdAsync(Guid id) => _mapper.Map<FormControlValueResponse>(await _repository.GetAsync(id));
        public async Task<IEnumerable<FormControlValueResponse>> GetAllAsync() => _mapper.Map <IEnumerable<FormControlValueResponse>>(await _repository.GetListAsync());
        public async Task<FormControlValueResponse> GetByValueAsync(string value) =>
            _mapper.Map<FormControlValueResponse>((await _repository.GetListAsync(o => o.Value == value)).FirstOrDefault());
    }

}
