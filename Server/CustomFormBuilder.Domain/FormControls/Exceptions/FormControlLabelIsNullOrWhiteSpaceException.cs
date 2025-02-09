namespace CustomFormBuilder.Domain.FormControls.Exceptions
{
    internal class FormControlLabelIsNullOrWhiteSpaceException : Exception
    {
        public FormControlLabelIsNullOrWhiteSpaceException()
           : base("Form control's Label could not be empty or whitespace.")
        {

        }
    }
}
