using CustomFormBuilder.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormVersions
{
    public interface IFormVersionRepository:IBaseRepository<FormVersion, Guid>
    {
    }
}
