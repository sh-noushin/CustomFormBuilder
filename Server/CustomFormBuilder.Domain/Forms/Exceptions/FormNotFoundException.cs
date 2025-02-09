using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.Forms.Exceptions
{
    public class FormNotFoundException : Exception
    {
        public FormNotFoundException(string msg)
           : base(msg)
        {

        }
    }
}
