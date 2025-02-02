namespace CustomFormBuilder.Domain.FormSubmissionValues.Exceptions
{
    internal class FormSubmissionValueControlIdIsNullException : Exception
    {
        public FormSubmissionValueControlIdIsNullException()
            : base("Form submission value must be linked to a valid FormControl.") { }
    }
}
