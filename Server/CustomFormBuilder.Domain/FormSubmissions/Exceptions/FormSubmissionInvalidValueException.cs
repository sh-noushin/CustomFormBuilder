namespace CustomFormBuilder.Domain.FormSubmissions.Exceptions
{
    public class FormSubmissionInvalidValueException : Exception
    {
        public FormSubmissionInvalidValueException(string msg)
            : base(msg) { }
    }
}
