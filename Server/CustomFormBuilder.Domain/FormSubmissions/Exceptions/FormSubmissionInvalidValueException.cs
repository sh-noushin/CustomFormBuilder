using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormSubmissions.Exceptions
{
    public class FormSubmissionInvalidValueException : Exception
    {
        public FormSubmissionInvalidValueException(string msg)
            : base(msg) { }
    }
}
