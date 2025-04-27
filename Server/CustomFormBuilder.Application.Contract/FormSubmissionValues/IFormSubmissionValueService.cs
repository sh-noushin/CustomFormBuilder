namespace CustomFormBuilder.Application.Contract.FormSubmissionValues
{
    public interface IFormSubmissionValueService
    {
        Task<Guid> CreateAsync(Guid formSubmissionId, Guid formControlId, string value);
        Task UpdateValueAsync(Guid id, string newValue);
        Task DeleteAsync(Guid id);
    }
}
