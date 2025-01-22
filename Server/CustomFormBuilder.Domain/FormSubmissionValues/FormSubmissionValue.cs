using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControls;
using CustomFormBuilder.Domain.FormSubmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormSubmissionValues
{
    public class FormSubmissionValue:BaseEntity<Guid>
    {
        public int FormSubmissionId { get; set; } 
        public FormSubmission FormSubmission { get; set; } 
        public int FormControlId { get; set; } 
        public FormControl FormControl { get; set; } 
        public string Value { get; set; } 
    }
}
