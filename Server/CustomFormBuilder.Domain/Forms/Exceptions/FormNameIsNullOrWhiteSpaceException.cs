namespace CustomFormBuilder.Domain.Forms.Exceptions
{
    internal class FormNameIsNullOrWhiteSpaceException : Exception
    {
        public FormNameIsNullOrWhiteSpaceException()
           : base("Form name could not be empty or whitespace.")
        {

        }
    }
}
