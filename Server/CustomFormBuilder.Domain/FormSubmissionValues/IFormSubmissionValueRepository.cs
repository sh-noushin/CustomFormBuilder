using CustomFormBuilder.Domain.Core;

namespace CustomFormBuilder.Domain.FormSubmissionValues
{
    public interface IFormSubmissionValueRepository: IBaseRepository<FormSubmissionValue, Guid>
    {
    }
}
