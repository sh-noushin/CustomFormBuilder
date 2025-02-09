using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormVersions.Exceptions
{
    public class FormVersionNotFoundException : Exception
    {
        public FormVersionNotFoundException(string msg)
            : base(msg) { }
    }
}
