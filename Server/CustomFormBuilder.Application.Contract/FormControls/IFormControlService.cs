using CustomFormBuilder.Domain.Shared.Enums;

namespace CustomFormBuilder.Application.Contract.FormControls
{
    public interface IFormControlService
    {
        Task<Guid> CreateAsync(string label, ControlType type, bool isRequired, Guid formVersionId);
        Task UpdateAsync(Guid id, string label, ControlType type, bool isRequired);
        Task DeleteAsync(Guid id);
    }
}
