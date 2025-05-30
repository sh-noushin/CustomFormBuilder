using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControlOptions.Exceptions;

namespace CustomFormBuilder.Domain.FormControlOptions
{
    public class FormControlOptionManager : IFormControlOptionManager
    {
        private readonly IFormControlOptionRepository _repository;

        public FormControlOptionManager(IFormControlOptionRepository repository)
        {
            _repository = repository;
        }

        public async Task<FormControlOption> CreateAsync(string value, string displayText, Guid formControlId)
        {
            var formControlOption = new FormControlOption(value, displayText, formControlId);
            await _repository.CreateAsync(formControlOption);
            return formControlOption;
        }

        public async Task UpdateAsync(Guid id, string value, string displayText)
        {
            var formControlOption = await _repository.GetAsync(id);
            if (formControlOption == null)
                throw new FormControlOptionNotFoundException($"Form control option with id {id} not found.");

            formControlOption.SetValue(value);
            formControlOption.SetDisplayText(displayText);

            await _repository.UpdateAsync(formControlOption);
        }

        public async Task DeleteAsync(Guid id)
        {
            var formControlOption = await _repository.GetAsync(id);
            if (formControlOption == null)
                throw new FormControlOptionNotFoundException($"Form control option with id {id} not found.");

            await _repository.DeleteAsync(formControlOption);
        }
    }
}
