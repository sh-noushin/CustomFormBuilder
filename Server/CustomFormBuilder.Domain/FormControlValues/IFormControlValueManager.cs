namespace CustomFormBuilder.Domain.FormControlValues
{
    public interface IFormControlValueManager
    {
        Task<FormControlValue> CreateAsync(string value, Guid formControlId);
        Task UpdateAsync(Guid id, string value);
        Task DeleteAsync(Guid id);
    }
}
