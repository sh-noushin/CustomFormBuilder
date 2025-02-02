namespace CustomFormBuilder.Domain.FormSubmissions.Exceptions
{
    internal class FormSubmissionFormIdIsNullException : Exception
    {
        public FormSubmissionFormIdIsNullException()
            : base("Form submission must have a valid FormId.") { }
    }
}
