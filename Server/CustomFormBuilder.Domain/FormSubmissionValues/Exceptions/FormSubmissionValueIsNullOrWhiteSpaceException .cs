namespace CustomFormBuilder.Domain.FormSubmissionValues.Exceptions
{
    internal class FormSubmissionValueIsNullOrWhiteSpaceException : Exception
    {
        public FormSubmissionValueIsNullOrWhiteSpaceException()
            : base("Form submission value cannot be null or empty.") { }
    }
}
