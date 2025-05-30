using AutoMapper;
using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Response;
using CustomFormBuilder.Application.Contract.FormControls.Dtos.Response;
using CustomFormBuilder.Domain.FormControlOptions;
using CustomFormBuilder.Domain.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Application.FormControls
{
    public class FormControlMappingProfile : Profile
    {
        public FormControlMappingProfile()
        {
            CreateMap<FormControl, FormControlResponse>().ReverseMap();
        }
    }
}
