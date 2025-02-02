using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormControlOptions.Exceptions
{
    internal class FormControlOptionDisplayTextIsNullOrWhiteSpaceException : Exception
    {
        public FormControlOptionDisplayTextIsNullOrWhiteSpaceException()
            : base("Form control option display text cannot be null or empty.") { }
    }
}
