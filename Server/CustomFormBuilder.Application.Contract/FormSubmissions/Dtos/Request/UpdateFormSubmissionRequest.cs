using CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Request;

namespace CustomFormBuilder.Application.Contract.FormSubmissions.Dtos.Request
{
    public record UpdateFormSubmissionRequest(
        Guid Id,
        List<UpdateFormSubmissionValueRequest> Values
    );
}
