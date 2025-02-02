namespace CustomFormBuilder.Domain.FormSubmissions.Exceptions
{
    internal class FormSubmissionInvalidControlException : Exception
    {
        public FormSubmissionInvalidControlException(string message) : base(message) { }
    }
}
