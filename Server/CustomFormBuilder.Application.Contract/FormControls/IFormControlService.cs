using CustomFormBuilder.Application.Contract.FormControls.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormControls.Dtos.Response;
using CustomFormBuilder.Domain.Shared.Enums;

namespace CustomFormBuilder.Application.Contract.FormControls
{
    public interface IFormControlService
    {
        Task<Guid> CreateAsync(CreateFormControlRequest request);
        Task UpdateAsync(UpdateFormControlRequest request);
        Task DeleteAsync(Guid id);
        Task<FormControlResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<FormControlResponse>> GetAllAsync();
        Task<FormControlResponse> GetByLabelAsync(string label);

    }
}
