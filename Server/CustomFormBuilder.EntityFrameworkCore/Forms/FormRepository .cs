using CustomFormBuilder.Domain.Forms;
using CustomFormBuilder.EntityFrameworkCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.EntityFrameworkCore.Forms
{
    public class FormRepository : BaseRepository<CustomFormBuilderDbContext, Form, Guid>, IFormRepository
    {
        public FormRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
    }
}
