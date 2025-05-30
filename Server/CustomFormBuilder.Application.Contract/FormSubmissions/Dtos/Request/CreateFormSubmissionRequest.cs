using CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Request;

namespace CustomFormBuilder.Application.Contract.FormSubmissions.Dtos.Request
{
    public record CreateFormSubmissionRequest(
        Guid FormId,
        Guid FormVersionId,
        List<CreateFormSubmissionValueRequest> Values
    );
}
