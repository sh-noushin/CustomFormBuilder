using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Response;
using CustomFormBuilder.Application.Contract.FormControlValues.Dtos.Request;

namespace CustomFormBuilder.Application.Contract.FormControlOptions
{
    public interface IFormControlValueService
    {
        Task<Guid> CreateAsync(CreateFormControlValueRequest request);
        Task UpdateAsync(UpdateFormControlValueRequest request);
        Task DeleteAsync(Guid id);
        Task<FormControlValueResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<FormControlValueResponse>> GetAllAsync();
        Task<FormControlValueResponse> GetByValueAsync(string value);

    }
}
