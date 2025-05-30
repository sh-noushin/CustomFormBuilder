using AutoMapper;
using CustomFormBuilder.Application.Contract.FormSubmissions.Dtos.Response;

namespace CustomFormBuilder.Application.FormSubmissions
{
    public class FormSubmissionMappingProfile : Profile
    {
        public FormSubmissionMappingProfile()
        {
            CreateMap<FormSubmission, FormSubmissionResponse>().ReverseMap();
        }
    }
}
