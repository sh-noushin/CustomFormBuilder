using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControls;
using CustomFormBuilder.Domain.FormControlOptions.Exceptions;


namespace CustomFormBuilder.Domain.FormControlOptions
{
    public class FormControlOption : BaseEntity<Guid>
    {
        public string Value { get; private set; }
        public string DisplayText { get; private set; }
        public Guid FormControlId { get; private set; }
        public FormControl FormControl { get; private set; } = null!;

        private FormControlOption() { } 

        public FormControlOption(string value, string displayText, Guid formControlId)
        {
            SetValue(value);
            SetDisplayText(displayText);
            SetFormControlId(formControlId);
        }

        public void SetValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FormControlOptionValueIsNullOrWhiteSpaceException();

            Value = value;
        }

        public void SetDisplayText(string displayText)
        {
            if (string.IsNullOrWhiteSpace(displayText))
                throw new FormControlOptionDisplayTextIsNullOrWhiteSpaceException();

            DisplayText = displayText;
        }

        public void SetFormControlId(Guid formControlId)
        {
            if (formControlId == Guid.Empty)
                throw new FormControlOptionFormControlIdIsNullException();

            FormControlId = formControlId;
        }
    }
}
