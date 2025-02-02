using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormControlOptions.Exceptions
{
    internal class FormControlOptionValueIsNullOrWhiteSpaceException  : Exception
    {
        public FormControlOptionValueIsNullOrWhiteSpaceException()
            : base("Form control option value cannot be null or empty.") { }
    }
}
