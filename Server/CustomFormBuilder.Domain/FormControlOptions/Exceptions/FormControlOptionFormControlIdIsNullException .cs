namespace CustomFormBuilder.Domain.FormControlOptions.Exceptions
{
    internal class FormControlOptionFormControlIdIsNullException : Exception
    {
        public FormControlOptionFormControlIdIsNullException()
            : base("Form control option must be linked to a valid FormControl.") { }
    }
}
