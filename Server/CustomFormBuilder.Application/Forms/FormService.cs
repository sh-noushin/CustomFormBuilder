using AutoMapper;
using CustomFormBuilder.Application.Contract.FormControls.Dtos.Response;
using CustomFormBuilder.Application.Contract.Forms;
using CustomFormBuilder.Application.Contract.Forms.Dtos.Request;
using CustomFormBuilder.Application.Contract.Forms.Dtos.Response;
using CustomFormBuilder.Application.Contract.FormVersions;
using CustomFormBuilder.Application.Contract.FormVersions.Dtos.Request;
using CustomFormBuilder.Domain.Core;
using CustomFormBuilder.Domain.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Application.Forms
{
    public class FormService : IFormService
    {
        private readonly IFormManager _manager;
        private readonly IFormVersionService _versionService;
        private readonly IFormRepository _repository;
        private readonly IMapper _mapper;


        public FormService(IFormManager manager, IFormVersionService versionService, IFormRepository repository, IMapper mapper)
        {
            _manager = manager;
            _versionService = versionService;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> CreateAsync(CreateFormRequest request)
        {
            var form = await _manager.CreateAsync(request.Name);
            return form.Id;
        }

        public async Task UpdateAsync(UpdateFormRequest request)
        {
            await _manager.UpdateAsync(request.Id, request.Name);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _manager.DeleteAsync(id);
        }

        public async Task<Guid> AddVersionAsync(Guid formId, string version)
        {
            return await _versionService.CreateAsync(new CreateFormVersionRequest(version, formId));

        }

        public async Task<FormResponse> GetByIdAsync(Guid id) => _mapper.Map<FormResponse>(await _repository.GetAsync(id));
        public async Task<IEnumerable<FormResponse>> GetAllAsync() => _mapper.Map<IEnumerable<FormResponse>>(await _repository.GetListAsync());
        public async Task<FormResponse> GetByNameAsync(string name) =>
            _mapper.Map<FormResponse>((await _repository.GetListAsync(f => f.Name == name)).FirstOrDefault());
    }

}
