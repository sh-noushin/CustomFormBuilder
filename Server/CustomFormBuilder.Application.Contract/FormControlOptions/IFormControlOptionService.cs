namespace CustomFormBuilder.Application.Contract.FormControlOptions
{
    public interface IFormControlOptionService
    {
        Task<Guid> CreateAsync(string value, string displayText, Guid formControlId);
        Task UpdateAsync(Guid id, string value, string displayText);
        Task DeleteAsync(Guid id);
    }
}
