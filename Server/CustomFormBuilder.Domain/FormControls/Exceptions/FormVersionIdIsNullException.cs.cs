namespace CustomFormBuilder.Domain.FormControls.Exceptions
{
    internal class FormVersionIdIsNullException : Exception
    {
        public FormVersionIdIsNullException()
           : base("Form control's FormVersionId could not be empty or whitespace.")
        {

        }
    }
}
