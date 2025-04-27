namespace CustomFormBuilder.Domain.Forms.Exceptions
{
    public class FormNotFoundException : Exception
    {
        public FormNotFoundException(string msg)
           : base(msg)
        {

        }
    }
}
