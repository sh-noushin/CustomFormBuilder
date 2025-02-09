using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormSubmissions.Exceptions;
using CustomFormBuilder.Domain.FormSubmissionValues;


namespace CustomFormBuilder.Domain.FormSubmissions
{  

    public class FormSubmissionManager : IFormSubmissionManager
    {
        private readonly IBaseRepository<FormSubmission, Guid> _repository;
        private readonly IBaseRepository<FormSubmissionValue, Guid> _submissionValueRepository;

        public FormSubmissionManager(IBaseRepository<FormSubmission, Guid> repository,
                                     IBaseRepository<FormSubmissionValue, Guid> submissionValueRepository)
        {
            _repository = repository;
            _submissionValueRepository = submissionValueRepository;
        }

        public async Task<FormSubmission> CreateAsync(Guid formId, Guid formVersionId)
        {
            var formSubmission = new FormSubmission(formId, formVersionId);
            await _repository.CreateAsync(formSubmission);
            return formSubmission;
        }

        public async Task AddValueAsync(Guid submissionId, Guid formControlId, string value)
        {
            var formSubmission = await _repository.GetAsync(submissionId);
            if (formSubmission == null)
                throw new FormSubmissionNotFoundException($"Form submission with ID {submissionId} not found.");

            formSubmission.AddValue(formControlId, value);

            await _repository.UpdateAsync(formSubmission);
        }

        public async Task DeleteAsync(Guid id)
        {
            var formSubmission = await _repository.GetAsync(id);
            if (formSubmission == null)
                throw new FormSubmissionNotFoundException($"Form submission with ID {id} not found.");

            await _repository.DeleteAsync(formSubmission);
        }
    }

}
