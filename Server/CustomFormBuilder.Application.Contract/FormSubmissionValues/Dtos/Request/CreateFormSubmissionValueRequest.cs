namespace CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Request
{
    public record CreateFormSubmissionValueRequest(
       Guid FormSubmissionId,
       Guid FormControlId,
       string Value
   );
}
