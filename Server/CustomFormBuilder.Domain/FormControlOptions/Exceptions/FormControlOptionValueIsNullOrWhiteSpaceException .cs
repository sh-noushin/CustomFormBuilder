namespace CustomFormBuilder.Domain.FormControlOptions.Exceptions
{
    internal class FormControlOptionValueIsNullOrWhiteSpaceException  : Exception
    {
        public FormControlOptionValueIsNullOrWhiteSpaceException()
            : base("Form control option value cannot be null or empty.") { }
    }
}
