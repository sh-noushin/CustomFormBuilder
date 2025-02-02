using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormControls.Exceptions
{
    internal class FormVersionIdIsNullException : Exception
    {
        public FormVersionIdIsNullException()
           : base("FormControl's FormVersionId could not be empty or whitespace.")
        {

        }
    }
}
