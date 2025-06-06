﻿using AutoMapper;
using CustomFormBuilder.Application.Contract.Forms.Dtos.Response;
using CustomFormBuilder.Application.Contract.FormSubmissions;
using CustomFormBuilder.Application.Contract.FormSubmissions.Dtos.Request;
using CustomFormBuilder.Application.Contract.FormSubmissions.Dtos.Response;
using CustomFormBuilder.Application.Contract.FormSubmissionValues.Dtos.Request;
using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.FormSubmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Application.FormSubmissions
{
    public class FormSubmissionService : IFormSubmissionService
    {
        private readonly IFormSubmissionManager _manager;
        private readonly IFormSubmissionRepository _repository;
        private readonly IMapper _mapper;


        public FormSubmissionService(IFormSubmissionManager manager, IFormSubmissionRepository repository, IMapper mapper)
        {
            _manager = manager;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> CreateAsync(CreateFormSubmissionRequest model)
        {
            var submission = await _manager.CreateAsync(model.FormId, model.FormVersionId);
            return submission.Id;
        }

        public async Task AddValueAsync(Guid submissionId, CreateFormSubmissionValueRequest value)
        {
            await _manager.AddValueAsync(submissionId, value.FormControlId, value.Value);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _manager.DeleteAsync(id);
        }

        public async Task<FormSubmissionResponse> GetByIdAsync(Guid id) => _mapper.Map<FormSubmissionResponse>(await _repository.GetAsync(id));
        public async Task<IEnumerable<FormSubmissionResponse>> GetAllAsync() => _mapper.Map<IEnumerable<FormSubmissionResponse>>(await _repository.GetListAsync());
    }

}
