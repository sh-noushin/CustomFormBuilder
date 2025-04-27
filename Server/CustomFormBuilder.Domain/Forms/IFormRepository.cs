using CustomFormBuilder.Domain.Core;

namespace CustomFormBuilder.Domain.Forms
{
    public interface IFormRepository:IBaseRepository<Form, Guid>
    {
    }
}
