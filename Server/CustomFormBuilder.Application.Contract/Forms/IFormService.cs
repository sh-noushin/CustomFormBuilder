using CustomFormBuilder.Application.Contract.Forms.Dtos.Request;
using CustomFormBuilder.Application.Contract.Forms.Dtos.Response;

namespace CustomFormBuilder.Application.Contract.Forms
{
    public interface IFormService
    {
        Task<Guid> CreateAsync(CreateFormRequest request);
        Task UpdateAsync(UpdateFormRequest request);
        Task DeleteAsync(Guid id);
        Task<Guid> AddVersionAsync(Guid formId, string version);
        Task<FormResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<FormResponse>> GetAllAsync();
        Task<FormResponse> GetByNameAsync(string name);

    }
}
