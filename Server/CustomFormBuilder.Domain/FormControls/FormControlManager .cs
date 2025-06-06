﻿using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControls.Exceptions;
using CustomFormBuilder.Domain.Shared.Enums;

namespace CustomFormBuilder.Domain.FormControls
{
    public class FormControlManager : IFormControlManager
    {
        private readonly IFormControlRepository _repository;

        public FormControlManager(IFormControlRepository repository)
        {
            _repository = repository;
        }

        public async Task<FormControl> CreateAsync(string label, ControlType type, bool isRequired, Guid formVersionId)
        {
            var formControl = new FormControl(label, type, isRequired, formVersionId);
            await _repository.CreateAsync(formControl);
            return formControl;
        }

        public async Task UpdateAsync(Guid id, string label, ControlType type, bool isRequired)
        {
            var formControl = await _repository.GetAsync(id);
            if (formControl == null)
                throw new FormControlNotFoundException($"Form control with id {id} not found.");

            formControl.SetLabel(label);
            formControl.SetType(type);
            formControl.IsRequired = isRequired;

            await _repository.UpdateAsync(formControl);
        }

        public async Task DeleteAsync(Guid id)
        {
            var formControl = await _repository.GetAsync(id);
            if (formControl == null)
                throw new FormControlNotFoundException($"Form control with id {id} not found.");

            await _repository.DeleteAsync(formControl);
        }
    }
}
