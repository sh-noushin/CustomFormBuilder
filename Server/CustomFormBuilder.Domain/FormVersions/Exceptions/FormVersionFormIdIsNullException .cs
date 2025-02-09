namespace CustomFormBuilder.Domain.FormVersions.Exceptions
{
    internal class FormVersionFormIdIsNullException : Exception
    {
        public FormVersionFormIdIsNullException()
            : base("Form version must be linked to a valid FormId.") { }
    }
}
