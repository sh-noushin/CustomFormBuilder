using CustomFormBuilder.Domain.FormVersions;

namespace CustomFormBuilder.Domain.Forms
{
    public interface IFormManager
    {
        Task<Form> CreateAsync(string name);
        Task UpdateAsync(Guid id, string name);
        Task DeleteAsync(Guid id);
        Task<FormVersion> AddVersionAsync(Guid formId, string version);
    }
}
