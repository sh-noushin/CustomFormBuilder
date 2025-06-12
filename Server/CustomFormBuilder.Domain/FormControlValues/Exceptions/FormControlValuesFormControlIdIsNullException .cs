namespace CustomFormBuilder.Domain.FormControlValues.Exceptions
{
    internal class FormControlValuesFormControlIdIsNullException : Exception
    {
        public FormControlValuesFormControlIdIsNullException()
            : base("Form control value must be linked to a valid FormControl.") { }
    }
}
