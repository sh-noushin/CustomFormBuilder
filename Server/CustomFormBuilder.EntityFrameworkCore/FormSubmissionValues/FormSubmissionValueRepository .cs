using CustomFormBuilder.Domain.FormSubmissionValues;
using CustomFormBuilder.EntityFrameworkCore.Core;

namespace CustomFormBuilder.EntityFrameworkCore.FormSubmissionValues
{
    public class FormSubmissionValueRepository
    : BaseRepository<CustomFormBuilderDbContext, FormSubmissionValue, Guid>, IFormSubmissionValueRepository
    {
        public FormSubmissionValueRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
    }
}
