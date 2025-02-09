namespace CustomFormBuilder.Domain.FormControlOptions.Exceptions
{
    public class FormControlOptionNotFoundException : Exception
    {
        public FormControlOptionNotFoundException(string msg)
            : base(msg) { }
    }
}
