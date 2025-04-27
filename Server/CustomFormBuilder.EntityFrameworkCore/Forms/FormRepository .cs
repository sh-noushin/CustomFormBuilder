using CustomFormBuilder.Domain.Forms;
using CustomFormBuilder.EntityFrameworkCore.Core;

namespace CustomFormBuilder.EntityFrameworkCore.Forms
{
    public class FormRepository : BaseRepository<CustomFormBuilderDbContext, Form, Guid>, IFormRepository
    {
        public FormRepository(CustomFormBuilderDbContext db) : base(db)
        {
        }
    }
}
