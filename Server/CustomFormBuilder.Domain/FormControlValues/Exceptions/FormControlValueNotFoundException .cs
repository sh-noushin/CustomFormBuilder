namespace CustomFormBuilder.Domain.FormControlValues.Exceptions
{
    public class FormControlValueNotFoundException : Exception
    {
        public FormControlValueNotFoundException(string msg)
            : base(msg) { }
    }
}
