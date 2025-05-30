using AutoMapper;
using CustomFormBuilder.Application.Contract.FormVersions.Dtos.Response;
using CustomFormBuilder.Domain.FormVersions;

namespace CustomFormBuilder.Application.FormVersions
{
    public class FormVersionMappingProfile : Profile
    {
        public FormVersionMappingProfile()
        {
            CreateMap<FormVersion, FormVersionResponse>().ReverseMap();
        }
    }
}
