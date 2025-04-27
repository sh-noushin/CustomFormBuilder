namespace CustomFormBuilder.Domain.FormSubmissions.Exceptions
{
    internal class FormSubmissionNotFoundException : Exception
    {
        public FormSubmissionNotFoundException(string msg)
            : base(msg) { }
    }
}
