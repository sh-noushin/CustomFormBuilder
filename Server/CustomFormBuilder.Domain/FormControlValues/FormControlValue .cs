using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControls;
using CustomFormBuilder.Domain.FormControlValues.Exceptions;


namespace CustomFormBuilder.Domain.FormControlValues
{
    public class FormControlValue : BaseEntity<Guid>
    {
        public string Value { get; private set; }
        public Guid FormControlId { get; private set; }
        public FormControl FormControl { get; private set; } = null!;

        private FormControlValue() { } 

        public FormControlValue(string value, Guid formControlId)
        {
            SetValue(value);
            SetFormControlId(formControlId);
        }

        public void SetValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FormControlValueIsNullOrWhiteSpaceException();

            Value = value;
        }

        
        public void SetFormControlId(Guid formControlId)
        {
            if (formControlId == Guid.Empty)
                throw new FormControlValuesFormControlIdIsNullException();

            FormControlId = formControlId;
        }
    }
}
