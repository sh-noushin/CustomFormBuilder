namespace CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Request
{
    public record CreateFormControlOptionRequest(
        string Value,
        string DisplayText,
        Guid FormControlId
    );
}
