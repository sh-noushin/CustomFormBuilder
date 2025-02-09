using CustomFormBuilder.Domain.FormVersions;
using CustomFormBuilder.EntityFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.EntityFrameworkCore.FormVersions
{
    public class FormVersionRepository : BaseRepository<CustomFormBuilderDbContext, FormVersion, Guid>, IFormVersionRepository
    {
        public FormVersionRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
    }
}
