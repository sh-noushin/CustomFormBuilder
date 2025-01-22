using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormVersions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.Forms
{
    public class Form:BaseEntity<Guid>
    {
        public string Name { get; set; } 
        public ICollection<FormVersion> Versions { get; set; } = new List<FormVersion>();
    }
}
