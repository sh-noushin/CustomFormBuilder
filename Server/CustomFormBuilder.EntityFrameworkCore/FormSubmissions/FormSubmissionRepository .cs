using CustomFormBuilder.Domain.FormSubmissions;
using CustomFormBuilder.EntityFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
