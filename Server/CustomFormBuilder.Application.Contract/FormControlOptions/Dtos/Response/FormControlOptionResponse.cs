namespace CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Response
{
    public record FormControlOptionResponse(
       Guid Id,
       string Value,
       string DisplayText,
       Guid FormControlId
   );
}
