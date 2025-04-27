namespace CustomFormBuilder.Domain.FormVersions
{
    public interface IFormVersionManager
    {
        Task<FormVersion> CreateAsync(string version, Guid formId);
        Task UpdateVersionAsync(Guid id, string newVersion);
        Task DeleteAsync(Guid id);
    }
}
