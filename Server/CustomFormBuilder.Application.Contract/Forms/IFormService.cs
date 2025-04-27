namespace CustomFormBuilder.Application.Contract.Forms
{
    public interface IFormService
    {
        Task<Guid> CreateAsync(string name);
        Task UpdateAsync(Guid id, string name);
        Task DeleteAsync(Guid id);
        Task<Guid> AddVersionAsync(Guid formId, string version);
    }
}
