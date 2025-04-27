namespace CustomFormBuilder.Domain.FormSubmissionValues.Exceptions
{
    public class FormSubmissionValueNotFoundException : Exception
    {
        public FormSubmissionValueNotFoundException(string msg)
            : base(msg) { }
    }
}
