using CustomFormBuilder.Domain.Core;

namespace CustomFormBuilder.Domain.FormSubmissions
{
    public interface IFormSubmissionRepository:IBaseRepository<FormSubmission, Guid>
    {
    }
}
