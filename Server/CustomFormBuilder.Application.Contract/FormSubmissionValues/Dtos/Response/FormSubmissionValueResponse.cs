namespace CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Response
{
    public record FormSubmissionValueResponse(
        Guid FormControlId,
        string Value
    );
}
