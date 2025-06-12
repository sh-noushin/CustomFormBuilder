using CustomFormBuilder.Application.Contract.FormControlOptions;
using CustomFormBuilder.Application.Contract.FormControls;
using CustomFormBuilder.Application.Contract.Forms;
using CustomFormBuilder.Application.Contract.FormSubmissions;
using CustomFormBuilder.Application.Contract.FormSubmissionValues;
using CustomFormBuilder.Application.Contract.FormVersions;
using CustomFormBuilder.Application.FormControlOptions;
using CustomFormBuilder.Application.FormControls;
using CustomFormBuilder.Application.Forms;
using CustomFormBuilder.Application.FormSubmissions;
using CustomFormBuilder.Application.FormSubmissionValues;
using CustomFormBuilder.Application.Services;
using CustomFormBuilder.Domain.FormControlValues;
using CustomFormBuilder.Domain.FormControls;
using CustomFormBuilder.Domain.Forms;
using CustomFormBuilder.Domain.FormSubmissions;
using CustomFormBuilder.Domain.FormSubmissionValues;
using CustomFormBuilder.Domain.FormVersions;
using CustomFormBuilder.EntityFrameworkCore;
using CustomFormBuilder.EntityFrameworkCore.FormControlValues;
using CustomFormBuilder.EntityFrameworkCore.FormControls;
using CustomFormBuilder.EntityFrameworkCore.Forms;
using CustomFormBuilder.EntityFrameworkCore.FormSubmissions;
using CustomFormBuilder.EntityFrameworkCore.FormSubmissionValues;
using CustomFormBuilder.EntityFrameworkCore.FormVersions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CustomFormBuilder.Application
{
    public static class ApplicationServiceRegistrar
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // DbContext
            services.AddDbContext<CustomFormBuilderDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // AutoMapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Services
            services.AddScoped<IFormControlService, FormControlService>();
            services.AddScoped<IFormControlValueService, FormControlValueService>();
            services.AddScoped<IFormSubmissionService, FormSubmissionService>();
            services.AddScoped<IFormSubmissionValueService, FormSubmissionValueService>();
            services.AddScoped<IFormService, FormService>();
            services.AddScoped<IFormVersionService, FormVersionService>();

            // Managers
            services.AddScoped<IFormControlManager, FormControlManager>();
            services.AddScoped<IFormControlValueManager, FormControlValueManager>();
            services.AddScoped<IFormSubmissionManager, FormSubmissionManager>();
            services.AddScoped<IFormSubmissionValueManager, FormSubmissionValueManager>();
            services.AddScoped<IFormManager, FormManager>();
            services.AddScoped<IFormVersionManager, FormVersionManager>();

            // Repositories
            services.AddScoped<IFormControlRepository, FormControlRepository>();
            services.AddScoped<IFormControlValueRepository, FormControlValueRepository>();
            services.AddScoped<IFormSubmissionRepository, FormSubmissionRepository>();
            services.AddScoped<IFormSubmissionValueRepository, FormSubmissionValueRepository>();
            services.AddScoped<IFormRepository, FormRepository>();
            services.AddScoped<IFormVersionRepository, FormVersionRepository>();

            return services;
        }
    }
}
