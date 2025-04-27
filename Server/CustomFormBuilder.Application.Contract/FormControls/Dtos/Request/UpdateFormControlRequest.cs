using CustomFormBuilder.Domain.Shared.Enums;

namespace CustomFormBuilder.Application.Contract.FormControls.Dtos.Request
{
    public record UpdateFormControlRequest(
       Guid Id,
       string Label,
       ControlType Type,
       bool IsRequired
   );
}
