using AutoMapper;
using CustomFormBuilder.Application.Contract.Forms.Dtos.Response;
using CustomFormBuilder.Domain.Forms;

namespace CustomFormBuilder.Application.Forms
{
    public class FormMappingProfile : Profile
    {
        public FormMappingProfile()
        {
            CreateMap<Form, FormResponse>().ReverseMap();
        }
    }
}
