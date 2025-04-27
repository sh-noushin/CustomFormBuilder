using CustomFormBuilder.Domain.FormSubmissions;
using CustomFormBuilder.EntityFrameworkCore.Core;

namespace CustomFormBuilder.EntityFrameworkCore.FormSubmissions
{
    public class FormSubmissionRepository
    : BaseRepository<CustomFormBuilderDbContext, FormSubmission, Guid>, IFormSubmissionRepository
    {
        public FormSubmissionRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
    }
}
