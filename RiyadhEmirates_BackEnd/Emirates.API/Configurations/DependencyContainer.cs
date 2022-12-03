using Dimah.Core.Application.Services.Charities;
using Dimah.Core.Application.Services.Shared;
using Dimah.Core.Domain.IRepositories;
using Dimah.InfraStructure.Repositories;
using Dimah.Core.Application.Services.Accounts;
using Dimah.Core.Application.Services.CharityProjects;
using Dimah.Core.Application.Services.Common;
using Dimah.Core.Application.Services.FileManagers;
using Dimah.Core.Application.Services.FileUploader;
using Dimah.Core.Application.Services.Lookups;
using Dimah.Core.Application.Services.ProjectTypes;
using Dimah.Core.Application.Services.Roles;
using Dimah.Core.Application.Services.UserRoles;

namespace Dimah.API.Configurations
{
    public class DependencyContainer
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            #region UnitOfWorks
            builder.Services.AddScoped<IGenericUnitOfWork, GenericUnitOfWork>();
            builder.Services.AddScoped<ILookupRepository, LookupRepository>();
            #endregion

            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<ICharityService, CharityService>();
            builder.Services.AddScoped<ICharityProjectService, CharityProjectService>();
            builder.Services.AddScoped<ICommonService, CommonService>();
            builder.Services.AddScoped<IFileManagerService, FileManagerService>();
            builder.Services.AddScoped<IFileUploaderService, FileUploaderService>();
            builder.Services.AddScoped<ILookupService, LookupService>();
            builder.Services.AddScoped<IProjectTypeService, ProjectTypeService>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            builder.Services.AddScoped<IUserRoleService, UserRoleService>();
            builder.Services.AddScoped<ILocalizationService, LocalizationService>();

        }
    }
}
