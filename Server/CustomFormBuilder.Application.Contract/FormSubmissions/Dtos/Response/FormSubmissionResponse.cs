using CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Response;

namespace CustomFormBuilder.Application.Contract.FormSubmissions.Dtos.Response
{
    public record FormSubmissionResponse(
       Guid Id,
       Guid FormId,
       Guid FormVersionId,
       DateTime SubmittedAt,
       List<FormSubmissionValueResponse> Values
   );
}
