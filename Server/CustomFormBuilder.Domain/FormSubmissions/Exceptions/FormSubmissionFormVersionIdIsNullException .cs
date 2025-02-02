namespace CustomFormBuilder.Domain.FormSubmissions.Exceptions
{
    internal class FormSubmissionFormVersionIdIsNullException : Exception
    {
        public FormSubmissionFormVersionIdIsNullException()
            : base("Form submission must have a valid FormVersionId.") { }
    }
}
