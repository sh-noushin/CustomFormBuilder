using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormControls;
using CustomFormBuilder.Domain.Forms;
using CustomFormBuilder.Domain.FormVersions.Exceptions;

namespace CustomFormBuilder.Domain.FormVersions
{
    public class FormVersion : BaseEntity<Guid>
    {
        public Guid FormId { get; private set; }
        public Form Form { get; private set; }

        public string Version { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

        public ICollection<FormControl> Controls { get; private set; } = new List<FormControl>();

        private FormVersion() { } 

        public FormVersion(string version, Guid formId)
        {
            SetVersion(version);
            SetFormId(formId);
        }

        private void SetFormId(Guid formId)
        {
            if (formId == Guid.Empty)
                throw new FormVersionFormIdIsNullException();

            FormId = formId;
        }

        public void SetVersion(string version)
        {
            if (string.IsNullOrWhiteSpace(version))
                throw new FormVersionIsNullOrWhiteSpaceException();

            Version = version;
        }
    }
}
