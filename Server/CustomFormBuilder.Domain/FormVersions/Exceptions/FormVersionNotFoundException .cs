namespace CustomFormBuilder.Domain.FormVersions.Exceptions
{
    public class FormVersionNotFoundException : Exception
    {
        public FormVersionNotFoundException(string msg)
            : base(msg) { }
    }
}
