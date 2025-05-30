using CustomFormBuilder.Application.Contract.FormSubmissions.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormSubmissions.Dtos.Response;
using CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Request;

namespace CustomFormBuilder.Application.Contract.FormSubmissions
{
    public interface IFormSubmissionService
    {
        Task<Guid> CreateAsync(CreateFormSubmissionRequest request);
        Task AddValueAsync(Guid submissionId, CreateFormSubmissionValueRequest value);
        Task DeleteAsync(Guid id);
        Task<FormSubmissionResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<FormSubmissionResponse>> GetAllAsync();

    }
}
