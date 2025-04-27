namespace CustomFormBuilder.Domain.Core.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException()
            : base("Entity not found.")
        {

        }
    }
}
