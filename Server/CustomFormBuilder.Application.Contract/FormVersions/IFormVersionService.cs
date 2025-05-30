using CustomFormBuilder.Application.Contract.FormVersions.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormVersions.Dtos.Response;

namespace CustomFormBuilder.Application.Contract.FormVersions
{
    public interface IFormVersionService
    {
        Task<Guid> CreateAsync(CreateFormVersionRequest request);
        Task UpdateVersionAsync(UpdateFormVersionRequest request);
        Task DeleteAsync(Guid id);
        Task<FormVersionResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<FormVersionResponse>> GetAllAsync();
        Task<FormVersionResponse> GetByVersionAsync(string version);
    }
}
