using CustomFormBuilder.Domain.FormControls;
using CustomFormBuilder.EntityFrameworkCore.Core;

namespace CustomFormBuilder.EntityFrameworkCore.FormControls
{
    public class FormControlRepository
    : BaseRepository<CustomFormBuilderDbContext, FormControl, Guid>, IFormControlRepository
    {
        public FormControlRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
    }
}
