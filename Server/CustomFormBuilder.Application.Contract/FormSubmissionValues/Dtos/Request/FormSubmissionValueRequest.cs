namespace CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Request
{
    public record FormSubmissionValueRequest(
       Guid FormControlId,
       string Value
   );
}
