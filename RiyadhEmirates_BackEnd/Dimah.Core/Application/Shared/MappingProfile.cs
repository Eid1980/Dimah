using AutoMapper;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Domain.Entities;

namespace Dimah.Core.Application.Shared
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Account
            CreateMap<CreateUserDto, User>();
            CreateMap<User, GetUserDto>()
                .ForMember(dest => dest.GenderName, src => src.MapFrom(m => m.IsMale ? "ذكر" : "أنثى"))
                .ForMember(dest => dest.NationalityName, src => src.MapFrom(m => m.Nationality.NameAr));
            CreateMap<User, GetUserSessionDto>()
                .ForMember(dest => dest.FullName, src => src.MapFrom(m => m.FullNameAr));
            CreateMap<User, GetUserDataDto>()
                .ForMember(dest => dest.Name, src => src.MapFrom(m => m.FullNameAr))
                .ForMember(dest => dest.GenderName, src => src.MapFrom(m => m.IsMale ? "ذكر" : "أنثى"));
            #endregion

            #region Charity
            CreateMap<CreateCharityDto, Charity>();
            CreateMap<UpdateCharityDto, Charity>();

            CreateMap<Charity, GetCharityDetailsDto>()
                .ForMember(dest => dest.CharityProjectList, src => src.MapFrom(m => m.CharityProjects.Select(model =>
                new GetCharityProjectListDto
                {
                    Id = model.Id,
                    NameAr = model.NameAr,
                    NameEn = model.NameEn,
                    ProjectTypeName = model.ProjectType.NameAr,
                    ProjectCost = model.ProjectCost,

                })));
            CreateMap<Charity, GetCharityListDto>();
            #endregion

            #region CharityProject
            CreateMap<CreateCharityProjectDto, CharityProject>()
                .ForMember(dest => dest.Image, src => src.MapFrom(m => !string.IsNullOrEmpty(m.Image) ? $"{Guid.NewGuid()}_{m.Image}" : m.Image));
            CreateMap<UpdateCharityProjectDto, CharityProject>()
                .ForMember(dest => dest.Image, src => src.MapFrom(m => !string.IsNullOrEmpty(m.Image) ? $"{Guid.NewGuid()}_{m.Image}" : m.Image));

            CreateMap<CharityProject, GetCharityProjectDetailsDto>()
                .ForMember(dest => dest.CharityName, src => src.MapFrom(m => m.Charity.NameAr))
                .ForMember(dest => dest.ProjectTypeName, src => src.MapFrom(m => m.ProjectType.NameAr));
            CreateMap<CharityProject, GetCharityProjectListDto>()
                .ForMember(dest => dest.CharityName, src => src.MapFrom(m => m.Charity.NameAr))
                .ForMember(dest => dest.ProjectTypeName, src => src.MapFrom(m => m.ProjectType.NameAr));
            #endregion

            #region ChartItem
            CreateMap<CreateChartItemDto, ChartItem>();
            CreateMap<UpdateChartItemDto, ChartItem>();

            CreateMap<ChartItem, GetChartItemDetailsDto>()
                .ForMember(dest => dest.CharityProjectName, src => src.MapFrom(m => m.CharityProject.NameAr));
            CreateMap<ChartItem, CurrentChartListDto>()
                .ForMember(dest => dest.CharityProjectName, src => src.MapFrom(m => m.CharityProject.NameAr))
                .ForMember(dest => dest.DonationTotal, src => src.MapFrom(m => m.DonationPeriod * m.DonationValue));
            #endregion

            #region DailyRequests
            CreateMap<CreateDailyRequestDto, DailyRequestMain>()
                .ForMember(dest => dest.DailyRequestStatusId, src => src.MapFrom(m => (int)SystemEnums.DailyRequestStatus.New));

            CreateMap<DailyRequestMain, GetDailyRequestListDto>()
                .ForMember(dest => dest.StartDate, src => src.MapFrom(m => m.StartDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.PayedCount, src => src.MapFrom(m => m.DailyRequestDetails.Where(x => x.IsPayed).Count()))
                .ForMember(dest => dest.NotPayedCount, src => src.MapFrom(m => m.DailyRequestDetails.Where(x => !x.IsPayed).Count()));

            CreateMap<DailyRequestDetail, GetDailyRequestDetailsListDto>()
                .ForMember(dest => dest.Day, src => src.MapFrom(m => m.Day.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.IsPayed, src => src.MapFrom(m => m.IsPayed ? "نعم" : "لا"))
                .ForMember(dest => dest.DonationValue, src => src.MapFrom(m => m.DailyRequestMain.DonationValue))
                .ForMember(dest => dest.Sms, src => src.MapFrom(m => "رسالة نصية يتم ادارتها"));

            #endregion

            #region FileManager
            CreateMap<CreateUploadedFileDto, UploadedFile>();
            CreateMap<UploadedFile, GetUploadedFileDto>();
            #endregion

            #region Nationality
            CreateMap<CreateNationalityDto, Nationality>();
            CreateMap<UpdateNationalityDto, Nationality>();

            CreateMap<Nationality, GetNationalityDetailsDto>();
            CreateMap<Nationality, GetNationalityListDto>();
            #endregion

            #region Poster
            CreateMap<CreatePosterDto, Poster>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));
            CreateMap<UpdatePosterDto, Poster>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));

            CreateMap<Poster, GetPosterDetailsDto>();
            CreateMap<Poster, GetPosterListDto>();
            #endregion

            #region ProjectType
            CreateMap<CreateProjectTypeDto, ProjectType>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));
            CreateMap<UpdateProjectTypeDto, ProjectType>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));

            CreateMap<ProjectType, GetProjectTypeDetailsDto>();
            CreateMap<ProjectType, GetProjectTypeListDto>();
            #endregion

            #region Role
            CreateMap<CreateRoleDto, Role>();
            CreateMap<UpdateRoleDto, Role>();

            CreateMap<Role, GetRoleDetailsDto>();
            CreateMap<Role, GetRoleListDto>();
            #endregion

            #region UserRole
            CreateMap<CreateUserRoleDto, UserRole>();

            CreateMap<UserRole, GetRolUsersDto>()
                .ForMember(dest => dest.UserFullName, src => src.MapFrom(m => m.User.FullNameAr))
                .ForMember(dest => dest.UserNationalId, src => src.MapFrom(m => m.User.UserName))
                .ForMember(dest => dest.UserPhoneNumber, src => src.MapFrom(m => m.User.PhoneNumber));
            CreateMap<User, GetUserListDto>()
                .ForMember(dest => dest.FullName, src => src.MapFrom(m => m.FullNameAr))
                .ForMember(dest => dest.NationalityName, src => src.MapFrom(m => m.Nationality.NameAr));

            CreateMap<UserRole, GetUserRoleListDto>()
                .ForMember(dest => dest.RoleNameAr, src => src.MapFrom(m => m.Role.NameAr))
                .ForMember(dest => dest.RoleNameEn, src => src.MapFrom(m => m.Role.NameEn));
            #endregion

        }
    }
}
