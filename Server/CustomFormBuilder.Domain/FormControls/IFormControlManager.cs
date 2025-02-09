using CustomFormBuilder.Domain.Shared.Enums;

namespace CustomFormBuilder.Domain.FormControls
{
    public interface IFormControlManager
    {
        Task<FormControl> CreateAsync(string label, ControlType type, bool isRequired, Guid formVersionId);
        Task UpdateAsync(Guid id, string label, ControlType type, bool isRequired);
        Task DeleteAsync(Guid id);
    }

}
