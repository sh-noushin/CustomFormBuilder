namespace CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Response
{
    public record FormSubmissionValueResponse(
        Guid Id,
        Guid FormSubmissionId,
        Guid FormControlId,
        string Value
    );
}
