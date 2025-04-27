using CustomFormBuilder.Domain.FormControlOptions;
using CustomFormBuilder.EntityFrameworkCore.Core;

namespace CustomFormBuilder.EntityFrameworkCore.FormControlOptions
{
    public class FormControlOptionRepository
     : BaseRepository<CustomFormBuilderDbContext, FormControlOption, Guid>, IFormControlOptionRepository
    {
        public FormControlOptionRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
    }
}
