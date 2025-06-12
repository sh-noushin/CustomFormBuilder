using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControlValues.Exceptions;

namespace CustomFormBuilder.Domain.FormControlValues
{
    public class FormControlValueManager : IFormControlValueManager
    {
        private readonly IFormControlValueRepository _repository;

        public FormControlValueManager(IFormControlValueRepository repository)
        {
            _repository = repository;
        }

        public async Task<FormControlValue> CreateAsync(string value, Guid formControlId)
        {
            var formControlOption = new FormControlValue(value, formControlId);
            await _repository.CreateAsync(formControlOption);
            return formControlOption;
        }

        public async Task UpdateAsync(Guid id, string value)
        {
            var formControlOption = await _repository.GetAsync(id);
            if (formControlOption == null)
                throw new FormControlValueNotFoundException($"Form control value with id {id} not found.");

            formControlOption.SetValue(value);

            await _repository.UpdateAsync(formControlOption);
        }

        public async Task DeleteAsync(Guid id)
        {
            var formControlOption = await _repository.GetAsync(id);
            if (formControlOption == null)
                throw new FormControlValueNotFoundException($"Form control value with id {id} not found.");

            await _repository.DeleteAsync(formControlOption);
        }
    }
}
