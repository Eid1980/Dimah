using AutoMapper.QueryableExtensions;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;
using Dimah.Core.Domain.Entities;
using X.PagedList;
using AutoMapper;
using Dimah.Core.Domain.IRepositories;
using Dimah.Core.Application.Services.FileManagers;
using Dimah.Core.Application.Shared;

namespace Dimah.Core.Application.Services.ProjectTypes
{
    public class ProjectTypeService : BaseService, IProjectTypeService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;
        public ProjectTypeService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper, IFileManagerService fileManagerService)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetById(Guid id)
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
            return GetResponse(message: CustumMessages.SaveSuccess(), data: new FileToUploadDto { Id = addedModel.Id.ToString(), FileName = addedModel.ImageName });
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

            var newProjectType = _mapper.Map<ProjectType>(updateModel);
            newProjectType.ImageName = string.IsNullOrEmpty(newProjectType.ImageName) ? projectType.ImageName : newProjectType.ImageName;
            string oldImageName = projectType.ImageName;

            _dimahUnitOfWork.Repository<ProjectType>().Update(projectType, newProjectType);
            if (_dimahUnitOfWork.ContextSaveChanges())
            {
                if (!string.IsNullOrEmpty(updateModel.ImageName) && !string.IsNullOrEmpty(oldImageName))
                    _fileManagerService.Delete(new DeleteFileDto
                    {
                        CategueryName = SystemEnums.FileCateguery.ProjectTypes,
                        Name = oldImageName
                    });
            }
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: new FileToUploadDto { Id = updateModel.Id.ToString(), FileName = newProjectType.ImageName });
        }
        public IApiResponse ChangeStatus(Guid id)
        {
            var projectType = _dimahUnitOfWork.Repository<ProjectType>().FirstOrDefault(n => n.Id == id);
            if (projectType == null)
                throw new NotFoundException(typeof(ProjectType).Name);

            projectType.IsActive = !projectType.IsActive;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse();
        }
        public IApiResponse Delete(Guid id)
        {
            var projectType = _dimahUnitOfWork.Repository<ProjectType>().FirstOrDefault(n => n.Id == id, x => x.CharityProjects);
            if (projectType == null)
                throw new NotFoundException(typeof(ProjectType).Name);
            if (projectType.CharityProjects.Count > 0)
                throw new BusinessException("نوع المشروع مضاف على المشاريع");

            _dimahUnitOfWork.Repository<ProjectType>().Remove(projectType);
            if (_dimahUnitOfWork.ContextSaveChanges())
                _fileManagerService.Delete(new DeleteFileDto
                {
                    CategueryName = SystemEnums.FileCateguery.ProjectTypes,
                    Name = projectType.ImageName
                });
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _dimahUnitOfWork.Repository<ProjectType>().Where(l => l.IsActive).Select(item =>
            new LookupDto<Guid>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
