namespace CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Request
{
    public record UpdateFormSubmissionValueRequest(
       Guid Id,
       string Value
   );
}
