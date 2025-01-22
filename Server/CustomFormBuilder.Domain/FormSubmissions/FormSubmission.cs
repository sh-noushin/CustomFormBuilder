using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.Forms;
using CustomFormBuilder.Domain.FormSubmissionValues;
using CustomFormBuilder.Domain.FormVersions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormSubmissions
{
    public class FormSubmission:BaseEntity<Guid>
    {
        public Guid FormId { get; set; } 
        public Form Form { get; set; } 
        public Guid FormVersionId { get; set; } 
        public FormVersion FormVersion { get; set; } 
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow; 
        public ICollection<FormSubmissionValue> Values { get; set; } = new List<FormSubmissionValue>(); // User's values
    }
}
