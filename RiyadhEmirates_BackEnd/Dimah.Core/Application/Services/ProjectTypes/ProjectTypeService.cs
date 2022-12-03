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

namespace Dimah.Core.Application.Services.ProjectTypes
{
    public class ProjectTypeService : BaseService, IProjectTypeService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public ProjectTypeService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var projectType = _dimahUnitOfWork.Repository<ProjectType>().FirstOrDefault(l => l.Id.Equals(id));
            if (projectType == null)
                throw new NotFoundException(typeof(ProjectType).Name);
            return GetResponse(data: _mapper.Map<GetProjectTypeDetailsDto>(projectType));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _dimahUnitOfWork.Repository<ProjectType>().GetQueryable()
               .ProjectTo<GetProjectTypeListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetProjectTypeListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var projectTypes = _dimahUnitOfWork.Repository<ProjectType>().Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetProjectTypeListDto>>(projectTypes));
        }

        public IApiResponse Create(CreateProjectTypeDto createModel)
        {
            if (_dimahUnitOfWork.Repository<ProjectType>().Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<ProjectType>().Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _dimahUnitOfWork.Repository<ProjectType>().Add(_mapper.Map<ProjectType>(createModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateProjectTypeDto updateModel)
        {
            var projectType = _dimahUnitOfWork.Repository<ProjectType>().FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (projectType == null)
                throw new NotFoundException(typeof(ProjectType).Name);

            if (_dimahUnitOfWork.Repository<ProjectType>().Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<ProjectType>().Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _dimahUnitOfWork.Repository<ProjectType>().Update(projectType, _mapper.Map<ProjectType>(updateModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var projectType = _dimahUnitOfWork.Repository<ProjectType>().FirstOrDefault(n => n.Id == id);
            if (projectType == null)
                throw new NotFoundException(typeof(ProjectType).Name);

            projectType.IsActive = !projectType.IsActive;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var projectType = _dimahUnitOfWork.Repository<ProjectType>().FirstOrDefault(n => n.Id == id, x => x.CharityProjects);
            if (projectType == null)
                throw new NotFoundException(typeof(ProjectType).Name);
            if (projectType.CharityProjects.Count > 0)
                throw new BusinessException("نوع المشروع مضاف على المشاريع");

            _dimahUnitOfWork.Repository<ProjectType>().Remove(projectType);
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _dimahUnitOfWork.Repository<ProjectType>().Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
