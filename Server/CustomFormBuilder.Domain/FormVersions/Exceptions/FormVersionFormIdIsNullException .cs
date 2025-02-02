namespace CustomFormBuilder.Domain.FormVersions.Exceptions
{
    internal class FormVersionFormIdIsNullException : Exception
    {
        public FormVersionFormIdIsNullException()
            : base("FormVersion must be linked to a valid FormId.") { }
    }
}
