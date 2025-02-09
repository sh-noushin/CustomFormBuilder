namespace CustomFormBuilder.Domain.FormControls.Exceptions
{
    internal class FormControlTypeIsNullException : Exception
    {
        public FormControlTypeIsNullException()
           : base("Form control's Type  could not be empty or whitespace.")
        {

        }
    }
}
