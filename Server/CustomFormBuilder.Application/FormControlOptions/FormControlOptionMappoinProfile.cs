using AutoMapper;
using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Response;
using CustomFormBuilder.Domain.FormControlOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Application.FormControlOptions
{
    public class FormControlOptionMappoinProfile : Profile
    {
        public FormControlOptionMappoinProfile()
        {
            CreateMap<FormControlOption, FormControlOptionResponse>().ReverseMap();
        }
    }
}
