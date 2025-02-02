using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.FormVersions
{
    public interface IFormVersionManager
    {
        Task<FormVersion> CreateAsync(string version, Guid formId);
        Task UpdateVersionAsync(Guid id, string newVersion);
        Task DeleteAsync(Guid id);
    }
}
