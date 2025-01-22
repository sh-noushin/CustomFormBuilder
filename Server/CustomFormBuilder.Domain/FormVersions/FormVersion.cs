using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControls;
using CustomFormBuilder.Domain.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormVersions
{
    public class FormVersion : BaseEntity<Guid>
    {
        public Guid FormId { get; set; } 
        public Form Form { get; set; } 
        public string Version { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
        public ICollection<FormControl> Controls { get; set; } = new List<FormControl>();
    }
}
