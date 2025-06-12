using AutoMapper;
using CustomFormBuilder.Application.Contract.FormControlOptions.Dtos.Response;
using CustomFormBuilder.Domain.FormControlValues;
using CustomFormBuilder.Domain.FormControlValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Application.FormControlOptions
{
    public class FormControlValueMappoinProfile : Profile
    {
        public FormControlValueMappoinProfile()
        {
            CreateMap<FormControlValue, FormControlValueResponse>().ReverseMap();
        }
    }
}
