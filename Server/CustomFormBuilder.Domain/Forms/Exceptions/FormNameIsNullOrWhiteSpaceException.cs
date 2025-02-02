using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.Forms.Exceptions
{
    internal class FormNameIsNullOrWhiteSpaceException : Exception
    {
        public FormNameIsNullOrWhiteSpaceException()
           : base("Form name could not be empty or whitespace.")
        {

        }
    }
}
