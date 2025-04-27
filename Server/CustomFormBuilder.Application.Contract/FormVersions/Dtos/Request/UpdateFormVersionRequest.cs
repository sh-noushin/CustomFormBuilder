namespace CustomFormBuilder.Application.Contract.FormVersions.Dtos.Request
{
    public record UpdateFormVersionRequest(
        Guid Id,
        string Version
    );
}
