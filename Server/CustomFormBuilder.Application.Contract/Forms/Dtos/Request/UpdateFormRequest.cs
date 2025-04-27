namespace CustomFormBuilder.Application.Contract.Forms.Dtos.Request
{
    public record UpdateFormRequest(
        Guid Id,
        string Name
    );
}
