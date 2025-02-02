using CustomFormBuilder.Domain.Core;

namespace CustomFormBuilder.Domain.FormControls
{
    public interface IFormControlRepository:IBaseRepository<FormControl, Guid>
    {
    }
}
