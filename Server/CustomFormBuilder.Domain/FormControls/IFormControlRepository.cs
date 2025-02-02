using CustomFormBuilder.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormControls
{
    public interface IFormControlRepository:IBaseRepository<FormControl, Guid>
    {
    }
}
