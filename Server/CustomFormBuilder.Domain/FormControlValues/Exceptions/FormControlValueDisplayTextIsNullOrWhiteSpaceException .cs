namespace CustomFormBuilder.Domain.FormControlValues.Exceptions
{
    internal class FormControlValueDisplayTextIsNullOrWhiteSpaceException : Exception
    {
        public FormControlValueDisplayTextIsNullOrWhiteSpaceException()
            : base("Form control option display text cannot be null or empty.") { }
    }
}
