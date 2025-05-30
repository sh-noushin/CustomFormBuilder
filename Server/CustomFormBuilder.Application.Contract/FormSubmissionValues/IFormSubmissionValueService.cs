using CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Response;

namespace CustomFormBuilder.Application.Contract.FormSubmissionValues
{
    public interface IFormSubmissionValueService
    {
        Task<Guid> CreateAsync(CreateFormSubmissionValueRequest request);
        Task UpdateValueAsync(UpdateFormSubmissionValueRequest request);
        Task DeleteAsync(Guid id);
        Task<FormSubmissionValueResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<FormSubmissionValueResponse>> GetAllAsync();
    }
}
