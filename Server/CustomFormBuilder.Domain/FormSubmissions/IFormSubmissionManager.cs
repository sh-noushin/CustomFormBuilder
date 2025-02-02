using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormSubmissions
{
    public interface IFormSubmissionManager
    {
        Task<FormSubmission> CreateAsync(Guid formId, Guid formVersionId);
        Task AddValueAsync(Guid submissionId, Guid formControlId, string value);
        Task DeleteAsync(Guid id);
    }

}
