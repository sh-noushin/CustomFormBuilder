using CustomFormBuilder.Domain.FormControls;
using CustomFormBuilder.EntityFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
