using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormControls.Exceptions
{
    internal class FormControlTypeIsNullException : Exception
    {
        public FormControlTypeIsNullException()
           : base("FormControl's Type  could not be empty or whitespace.")
        {

        }
    }
}
