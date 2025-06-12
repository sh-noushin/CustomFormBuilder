namespace CustomFormBuilder.Application.Contract.FormControlValues.Dtos.Request
{
    public record CreateFormControlValueRequest(
        string Value,
        Guid FormControlId
    );
}
