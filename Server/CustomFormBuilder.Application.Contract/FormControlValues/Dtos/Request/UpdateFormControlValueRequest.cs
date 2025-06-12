namespace CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Request
{
    public record UpdateFormControlValueRequest(
        Guid Id,
        string Value
    );
}
