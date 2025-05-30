using AutoMapper;
using CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Response;
using CustomFormBuilder.Domain.FormSubmissionValues;

namespace CustomFormBuilder.Application.FormSubmissionValues
{
    public class FormSubmissionValueMappingProfile : Profile
    {
        public FormSubmissionValueMappingProfile()
        {
            CreateMap<FormSubmissionValue, FormSubmissionValueResponse>().ReverseMap();
        }
    }
}
