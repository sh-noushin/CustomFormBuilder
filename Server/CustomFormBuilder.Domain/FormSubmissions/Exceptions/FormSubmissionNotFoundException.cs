using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormSubmissions.Exceptions
{
    internal class FormSubmissionNotFoundException : Exception
    {
        public FormSubmissionNotFoundException(string msg)
            : base(msg) { }
    }
}
