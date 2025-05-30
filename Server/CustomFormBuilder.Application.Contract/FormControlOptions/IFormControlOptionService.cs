using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Response;

namespace CustomFormBuilder.Application.Contract.FormControlOptions
{
    public interface IFormControlOptionService
    {
        Task<Guid> CreateAsync(CreateFormControlOptionRequest request);
        Task UpdateAsync(UpdateFormControlOptionRequest request);
        Task DeleteAsync(Guid id);
        Task<FormControlOptionResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<FormControlOptionResponse>> GetAllAsync();
        Task<FormControlOptionResponse> GetByValueAsync(string value);

    }
}
