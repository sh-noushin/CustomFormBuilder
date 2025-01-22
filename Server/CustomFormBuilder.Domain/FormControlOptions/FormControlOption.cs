using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormControlOptions
{
    public class FormControlOption: BaseEntity<Guid>
    {
        public string Value { get; set; } 
        public string DisplayText { get; set; } 
        public Guid FormControlId { get; set; } 
        public FormControl FormControl { get; set; } 
    }
}
