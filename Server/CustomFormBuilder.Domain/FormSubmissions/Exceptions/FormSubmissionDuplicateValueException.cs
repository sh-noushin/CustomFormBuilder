namespace CustomFormBuilder.Domain.FormSubmissions.Exceptions
{
    public class FormSubmissionDuplicateValueException : Exception
    {
        public FormSubmissionDuplicateValueException(string msg)
            : base(msg) { }
}
}
