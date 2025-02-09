namespace CustomFormBuilder.Domain.FormControls.Exceptions
{
    public class FormControlNotFoundException : Exception
    {
        public FormControlNotFoundException(string msg)
           : base(msg)
        {

        }
    }
}
