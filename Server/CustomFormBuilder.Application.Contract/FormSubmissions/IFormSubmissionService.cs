namespace CustomFormBuilder.Application.Contract.FormSubmissions
{
    public interface IFormSubmissionService
    {
        Task<Guid> CreateAsync(Guid formId, Guid formVersionId);
        Task AddValueAsync(Guid submissionId, Guid formControlId, string value);
        Task DeleteAsync(Guid id);
    }
}
