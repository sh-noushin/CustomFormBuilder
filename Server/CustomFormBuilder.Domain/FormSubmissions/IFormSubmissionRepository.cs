using CustomFormBuilder.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormSubmissions
{
    public interface IFormSubmissionRepository:IBaseRepository<FormSubmission, Guid>
    {
    }
}
