using AutoMapper.QueryableExtensions;
using Dimah.Core.Application.CustomExceptions;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.DynamicSearch;
using Dimah.Core.Application.Interfaces.Helpers;
using Dimah.Core.Application.Response;
using Dimah.Core.Domain.Entities;
using X.PagedList;
using AutoMapper;
using Dimah.Core.Domain.IRepositories;

namespace Dimah.Core.Application.Services.Roles
{
    public class RoleService : BaseService, IRoleService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public RoleService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var role = _dimahUnitOfWork.Repository<Role>().FirstOrDefault(l => l.Id.Equals(id));
            if (role == null)
                throw new NotFoundException(typeof(Role).Name);
            return GetResponse(data: _mapper.Map<GetRoleDetailsDto>(role));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _dimahUnitOfWork.Repository<Role>().GetQueryable()
               .ProjectTo<GetRoleListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetRoleListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var Roles = _dimahUnitOfWork.Repository<Role>().Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetRoleListDto>>(Roles));
        }

        public IApiResponse Create(CreateRoleDto createModel)
        {
            if (_dimahUnitOfWork.Repository<Role>().Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<Role>().Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _dimahUnitOfWork.Repository<Role>().Add(_mapper.Map<Role>(createModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateRoleDto updateModel)
        {
            var role = _dimahUnitOfWork.Repository<Role>().FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (role == null)
                throw new NotFoundException(typeof(Role).Name);

            if (_dimahUnitOfWork.Repository<Role>().Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<Role>().Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _dimahUnitOfWork.Repository<Role>().Update(role, _mapper.Map<Role>(updateModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var role = _dimahUnitOfWork.Repository<Role>().FirstOrDefault(n => n.Id == id);
            if (role == null)
                throw new NotFoundException(typeof(Role).Name);

            role.IsActive = !role.IsActive;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var role = _dimahUnitOfWork.Repository<Role>().FirstOrDefault(n => n.Id == id, x => x.UserRoles);
            if (role == null)
                throw new NotFoundException(typeof(Role).Name);
            if (role.UserRoles.Count > 0)
                throw new BusinessException("الصلاحية مضافة على مستخدمين");

            _dimahUnitOfWork.Repository<Role>().Remove(role);
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _dimahUnitOfWork.Repository<Role>().Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
