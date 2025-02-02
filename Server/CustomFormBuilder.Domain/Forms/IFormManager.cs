using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.Forms
{
    public interface IFormManager
    {
        Task<Form> CreateAsync(string name);
        Task UpdateAsync(Guid id, string name);
        Task DeleteAsync(Guid id);
    }
}
