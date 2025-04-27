namespace CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Request
{
    public record UpdateFormControlOptionRequest(
        Guid Id,
        string Value,
        string DisplayText
    );
}
