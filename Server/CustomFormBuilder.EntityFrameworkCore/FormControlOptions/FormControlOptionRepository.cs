using CustomFormBuilder.Domain.FormControlOptions;
using CustomFormBuilder.EntityFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
