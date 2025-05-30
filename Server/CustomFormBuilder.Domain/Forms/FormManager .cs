using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.Forms.Exceptions;
using CustomFormBuilder.Domain.FormVersions;

namespace CustomFormBuilder.Domain.Forms
{
    public class FormManager : IFormManager
    {
        private readonly IFormRepository _formRepository;
        private readonly IFormVersionRepository _formVersionRepository;

        public FormManager(IFormRepository formRepository, IFormVersionRepository formVersionRepository)
        {
            _formRepository = formRepository;
            _formVersionRepository = formVersionRepository;
        }

        public async Task<Form> CreateAsync(string name)
        {
            var form = new Form(name);
            await _formRepository.CreateAsync(form);
            return form;
        }

        public async Task UpdateAsync(Guid id, string name)
        {
            var form = await _formRepository.GetAsync(id);
            if (form == null)
                throw new FormNotFoundException($"Form with id {id} not found.");

            form.SetName(name);
            await _formRepository.UpdateAsync(form);
        }

        public async Task DeleteAsync(Guid id)
        {
            var form = await _formRepository.GetAsync(id);
            if (form == null)
                throw new FormNotFoundException($"Form with id {id} not found.");

            await _formRepository.DeleteAsync(form);
        }

        public async Task<FormVersion> AddVersionAsync(Guid formId, string version)
        {
            var form = await _formRepository.GetAsync(formId);
            if (form == null)
                throw new FormNotFoundException($"Form with id {formId} not found.");

            var formVersion = new FormVersion(version, formId);
            await _formVersionRepository.CreateAsync(formVersion);
            return formVersion;
        }
    }
}
