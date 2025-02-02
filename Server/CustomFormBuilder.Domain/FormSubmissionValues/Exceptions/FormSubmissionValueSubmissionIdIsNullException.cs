namespace CustomFormBuilder.Domain.FormSubmissionValues.Exceptions
{
    internal class FormSubmissionValueSubmissionIdIsNullException : Exception
    {
        public FormSubmissionValueSubmissionIdIsNullException()
            : base("Form submission value must be linked to a valid FormSubmission.") { }
    }
}
