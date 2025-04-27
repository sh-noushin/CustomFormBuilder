using CustomFormBuilder.Domain.Shared.Enums;

namespace CustomFormBuilder.Application.Contract.FormControls.Dtos.Response
{
    public record FormControlResponse(
       Guid Id,
       string Label,
       ControlType Type,
       bool IsRequired,
       Guid FormVersionId
   );
}
