using CustomFormBuilder.Application.Contract.FormControls.Dtos.Response;

namespace CustomFormBuilder.Application.Contract.FormVersions.Dtos.Response
{
    public record FormVersionResponse(
       Guid Id,
       string Version,
       Guid FormId,
       DateTime CreatedAt,
       List<FormControlResponse> Controls
   );
}
