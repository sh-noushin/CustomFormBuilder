using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControlOptions;
using CustomFormBuilder.Domain.FormSubmissionValues;
using CustomFormBuilder.Domain.FormVersions;
using CustomFormBuilder.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormControls
{
    public class FormControl: BaseEntity<Guid>
    {
        public string Label { get; set; } 
        public ControlType Type { get; set; } 
        public bool IsRequired { get; set; } 
        public Guid FormVersionId { get; set; } 
        public FormVersion FormVersion { get; set; } 
        public ICollection<FormControlOption> Options { get; set; } = new List<FormControlOption>();
        public ICollection<FormSubmissionValue> SubmissionValues { get; set; } = new List<FormSubmissionValue>();
    }
}
