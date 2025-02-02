using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormControls.Exceptions
{
    internal class FormControlLabelIsNullOrWhiteSpaceException : Exception
    {
        public FormControlLabelIsNullOrWhiteSpaceException()
           : base("FormControl's Label could not be empty or whitespace.")
        {

        }
    }
}
