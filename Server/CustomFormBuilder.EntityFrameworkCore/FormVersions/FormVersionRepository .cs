using CustomFormBuilder.Domain.FormVersions;
using CustomFormBuilder.EntityFrameworkCore.Core;

namespace CustomFormBuilder.EntityFrameworkCore.FormVersions
{
    public class FormVersionRepository : BaseRepository<CustomFormBuilderDbContext, FormVersion, Guid>, IFormVersionRepository
    {
        public FormVersionRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
    }
}
