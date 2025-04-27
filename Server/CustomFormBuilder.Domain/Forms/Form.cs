using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.Forms.Exceptions;
using CustomFormBuilder.Domain.FormVersions;
namespace CustomFormBuilder.Domain.Forms
{
    public class Form:BaseEntity<Guid>
    {
        public string Name { get; private set; } 
        public ICollection<FormVersion> Versions { get; set; } = new List<FormVersion>();

        private Form()
        {

        }

        public Form(string name)
        {
            SetName(name);
        }

        public void SetName(string name)
        {
            Name =  name ?? throw new FormNameIsNullOrWhiteSpaceException();
        }
    }
}
