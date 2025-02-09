using CustomFormBuilder.Domain.FormSubmissionValues;
using CustomFormBuilder.EntityFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
