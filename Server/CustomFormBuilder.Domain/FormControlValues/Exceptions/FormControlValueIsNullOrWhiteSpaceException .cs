namespace CustomFormBuilder.Domain.FormControlValues.Exceptions
{
    internal class FormControlValueIsNullOrWhiteSpaceException : Exception
    {
        public FormControlValueIsNullOrWhiteSpaceException()
            : base("Form control value cannot be null or empty.") { }
    }
}
