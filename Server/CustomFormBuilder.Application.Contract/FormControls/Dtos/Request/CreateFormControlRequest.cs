using CustomFormBuilder.Domain.Shared.Enums;

namespace CustomFormBuilder.Application.Contract.FormControls.Dtos.Request
{
    public record CreateFormControlRequest(
      string Label,
      ControlType Type,
      bool IsRequired,
      Guid FormVersionId
  );
}
