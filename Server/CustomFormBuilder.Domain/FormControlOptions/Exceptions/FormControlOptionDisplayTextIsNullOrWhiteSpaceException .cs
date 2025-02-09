namespace CustomFormBuilder.Domain.FormControlOptions.Exceptions
{
    internal class FormControlOptionDisplayTextIsNullOrWhiteSpaceException : Exception
    {
        public FormControlOptionDisplayTextIsNullOrWhiteSpaceException()
            : base("Form control option display text cannot be null or empty.") { }
    }
}
