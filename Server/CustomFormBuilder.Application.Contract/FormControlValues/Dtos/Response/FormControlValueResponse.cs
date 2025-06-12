namespace CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Response
{
    public record FormControlValueResponse(
       Guid Id,
       string Value,
       Guid FormControlId
   );
}
