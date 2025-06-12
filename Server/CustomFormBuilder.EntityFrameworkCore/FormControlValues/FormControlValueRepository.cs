using CustomFormBuilder.Domain.FormControlValues;
using CustomFormBuilder.EntityFrameworkCore.Core;

namespace CustomFormBuilder.EntityFrameworkCore.FormControlValues
{
    public class FormControlValueRepository
     : BaseRepository<CustomFormBuilderDbContext, FormControlValue, Guid>, IFormControlValueRepository
    {
        public FormControlValueRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
    }
}
