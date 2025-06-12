using CustomFormBuilder.Domain.FormVersions;
using CustomFormBuilder.EntityFrameworkCore.Core;
using Microsoft.EntityFrameworkCore;

namespace CustomFormBuilder.EntityFrameworkCore.FormVersions
{
    public class FormVersionRepository : BaseRepository<CustomFormBuilderDbContext, FormVersion, Guid>, IFormVersionRepository
    {
        public FormVersionRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
        public async Task<List<FormVersion>> GetListWithControlsAsync()
        {
            return await Db.FormVersions
                .Include(fv => fv.Controls)
                    .ThenInclude(fc => fc.Values)
                .ToListAsync();
        }
    }
}
