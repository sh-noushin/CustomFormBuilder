namespace CustomFormBuilder.Application.Contract.FormVersions.Dtos.Request
{
    public record CreateFormVersionRequest(
      string Version,
      Guid FormId
  );
}
