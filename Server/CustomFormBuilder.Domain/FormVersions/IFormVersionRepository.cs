using CustomFormBuilder.Domain.Core;

namespace CustomFormBuilder.Domain.FormVersions
{
    public interface IFormVersionRepository : IBaseRepository<FormVersion, Guid>
    {

        Task<List<FormVersion>> GetListWithControlsAsync();

    }
}
