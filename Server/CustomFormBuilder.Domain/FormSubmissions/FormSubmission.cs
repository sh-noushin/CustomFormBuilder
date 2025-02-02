using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.Forms;
using CustomFormBuilder.Domain.FormSubmissions.Exceptions;
using CustomFormBuilder.Domain.FormSubmissionValues;
using CustomFormBuilder.Domain.FormVersions;

public class FormSubmission : BaseEntity<Guid>
{
    public Guid FormId { get; private set; }
    public Form Form { get; private set; }

    public Guid FormVersionId { get; private set; }
    public FormVersion FormVersion { get; private set; }

    public DateTime SubmittedAt { get; private set; } = DateTime.UtcNow;

    public ICollection<FormSubmissionValue> Values { get; private set; } = new List<FormSubmissionValue>();

    private FormSubmission() { } 

    public FormSubmission(Guid formId, Guid formVersionId)
    {
        SetFormId(formId);
        SetFormVersionId(formVersionId);
        SubmittedAt = DateTime.UtcNow;
    }

    private void SetFormId(Guid formId)
    {
        if (formId == Guid.Empty)
            throw new FormSubmissionFormIdIsNullException();

        FormId = formId;
    }

    private void SetFormVersionId(Guid formVersionId)
    {
        if (formVersionId == Guid.Empty)
            throw new FormSubmissionFormVersionIdIsNullException();

        FormVersionId = formVersionId;
    }

    public void AddValue(Guid formControlId, string value)
    {
        if (formControlId == Guid.Empty)
            throw new FormSubmissionInvalidControlException("Form control ID cannot be empty.");

        Values.Add(new FormSubmissionValue(Id, formControlId, value));
    }
}
