namespace CustomFormBuilder.Domain.FormVersions.Exceptions
{
    internal class FormVersionIsNullOrWhiteSpaceException : Exception
    {
        public FormVersionIsNullOrWhiteSpaceException()
           : base("Form version could not be empty or whitespace.")
        {

        }
    }
}
