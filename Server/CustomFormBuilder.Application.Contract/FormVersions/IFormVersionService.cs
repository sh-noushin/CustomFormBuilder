namespace CustomFormBuilder.Application.Contract.FormVersions
{
    public interface IFormVersionService
    {
        Task<Guid> CreateAsync(string version, Guid formId);
        Task UpdateVersionAsync(Guid id, string newVersion);
        Task DeleteAsync(Guid id);
    }
}
