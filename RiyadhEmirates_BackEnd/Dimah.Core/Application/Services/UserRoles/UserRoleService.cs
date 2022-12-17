using AutoMapper.QueryableExtensions;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;
using Dimah.Core.Domain.Entities;
using X.PagedList;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Dimah.Core.Domain.IRepositories;
using Dimah.Core.Application.Shared;

namespace Dimah.Core.Application.Services.UserRoles
{
    public class UserRoleService : BaseService, IUserRoleService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserRoleService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper, 
            IHttpContextAccessor httpContextAccessor)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _httpContextAccessor = httpContextAccessor;
        }

        public IApiResponse GetUsersByRoleId(int roleId)
        {
            var roleUsers = _dimahUnitOfWork.Repository<UserRole>().Where(l => l.RoleId.Equals(roleId)).Include(x => x.User);
            return GetResponse(data: _mapper.Map<List<GetRolUsersDto>>(roleUsers));
        }
        public IApiResponse GetRolesByUserId(Guid userId)
        {
            var roleUsers = _dimahUnitOfWork.Repository<UserRole>().Where(l => l.UserId.Equals(userId)).Include(x => x.Role);
            return GetResponse(data: _mapper.Map<List<GetUserRoleListDto>>(roleUsers));
        }

        public IApiResponse Create(CreateUserRoleDto createModel)
        {
            if (_dimahUnitOfWork.Repository<UserRole>().Where(x => x.UserId.Equals(createModel.UserId) && x.RoleId.Equals(createModel.RoleId)).Any())
                throw new BusinessException("الصلاحية مضافة مسبقا على نفس المستخدم");

            var addedModel = _dimahUnitOfWork.Repository<UserRole>().Add(_mapper.Map<UserRole>(createModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Delete(Guid id)
        {
            var userRole = _dimahUnitOfWork.Repository<UserRole>().FirstOrDefault(n => n.Id == id);
            if (userRole == null)
                throw new NotFoundException(typeof(UserRole).Name);

            _dimahUnitOfWork.Repository<UserRole>().Remove(userRole);
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetAdminUsers(SearchModel searchModel)
        {
            searchModel.SearchFields.Add(new SearchField { FieldName = "IsEmployee", Operator = "Equal", Value = true.ToString() });
            var serchResult = _dimahUnitOfWork.Repository<User>().GetQueryable()
               .ProjectTo<GetUserListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetUserListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse IsAuthorize(string roles)
        {
            var arrRoles = roles.Split(',');
            Guid usreId = GetUserId();
            var isAuthorize = _dimahUnitOfWork.Repository<UserRole>().Where(r => r.UserId.Equals(usreId) && r.User.IsEmployee && arrRoles.Contains(r.RoleId.ToString())).Any();
            return GetResponse(isSuccess:isAuthorize, data: isAuthorize);
        }

        private Guid GetUserId()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                Guid.TryParse(_httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToLower().Contains("userid")).Value, out Guid userId);
                return userId;
            }
            return new Guid("83ee0b03-015e-4441-9294-8a4421d3b124");
        }

    }
}
